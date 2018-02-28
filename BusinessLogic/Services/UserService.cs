using System;
using System.Collections.Generic;
using AutoMapper;
using DataAccess.BaseRepository;
using DataAccess.EF;
using DataAccess.Repository;
using Model.ViewModel;
using static System.String;

namespace BusinessLogic.Services
{
    public interface IUserService
    {
        IEnumerable<UserItem> GetCount();
        void Create(UserModel model);
        void Delete(int id);
        void Update(UserModel model, int currentUserId);
        UserItem GetItem(int id);
        UserModel GetUser(int userId);
        UserDetail GetDetail(int id);
        bool NameExist(UserModel unit);

        bool Authenticate(UserModel model);
        bool Signup(UserModel model);
        UserModel FindByUsernamePassword(UserModel model);
    }
    public class UserService : IUserService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;
        private readonly IUserRepository _repository;

        public IEnumerable<UserItem> GetCount()
        {
            return ProcessQuery(_repository.Table);
        }
        public UserService(IUnitOfWorkAsync unitOfWork, IUserRepository repository)
        {
            _unitOfWork = unitOfWork;
            this._repository = repository;

        }

        public void Create(UserModel model)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var entity = Mapper.Map<UserModel, User>(model);
                entity.CreatedAt = DateTime.Now;
                _repository.Insert(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var entity = GetUserEntity(id);
                _repository.Delete(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public UserDetail GetDetail(int id)
        {
            var entity = GetUserEntity(id);
            return Mapper.Map<User, UserDetail>(entity);
        }

        public UserItem GetItem(int id)
        {
            var entity = GetUserEntity(id);
            return Mapper.Map<User, UserItem>(entity);
        }
        private static IEnumerable<UserItem> ProcessQuery(IEnumerable<User> entities)
        {
            return Mapper.Map<IEnumerable<User>, IEnumerable<UserItem>>(entities);
        }

        public void Update(UserModel model, int currentUserId)
        {

            try
            {
                _unitOfWork.BeginTransaction();
                var userProfile = GetUserEntity(model.Id);
                Mapper.Map(model, userProfile);
                _repository.Update(userProfile);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }
        private User GetUserEntity(int id)
        {
            return _repository.Find(id);

        }
        public UserModel GetUser(int userId)
        {
            var entity = GetUserEntity(userId);
            return Mapper.Map<User, UserModel>(entity);
        }

        public bool NameExist(UserModel brand)
        {
            return _repository.NameExist(brand);
        }

        public UserModel FindByUsernamePassword(UserModel model)
        {
            var entity = _repository.Find(c => model.Username.Equals(c.UserName, StringComparison.OrdinalIgnoreCase)
                                               && c.Password.Equals(model.Password, StringComparison.OrdinalIgnoreCase));

            return (entity != null) ? Mapper.Map<User, UserModel>(entity) : null;
        }

        public bool Authenticate(UserModel model)
        {
            return (FindByUsernamePassword(model) != null);
        }

        public bool Signup(UserModel model)
        {
            try
            {
                Create(model);
                return (FindByUsernamePassword(model) != null);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

