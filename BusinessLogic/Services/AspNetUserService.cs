using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataAccess.BaseRepository;
using DataAccess.EF;
using DataAccess.Repository;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Model.ViewModel;
using static System.String;

namespace BusinessLogic.Services
{
    public interface IAspNetUserService
    {
        IEnumerable<AspNetUserItem> GetCount(string roleName);
        void Create(AspNetUserModel model, out string id);
        void Delete(string id);
        void Update(AspNetUserModel model, int currentAspNetUserId);
        AspNetUserItem GetItem(string id);
        AspNetUserModel GetAspNetUser(string userId);
        AspNetUserDetail GetDetail(string id);
        bool NameExist(AspNetUserModel unit);
        List<string> CreateBulk(List<AspNetUserModel> models);
        AspNetUserModel GetStudentId(string matricNumber);
    }
    public class AspNetUserService : IAspNetUserService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;
        private readonly IAspNetUserRepository _repository;

        public IEnumerable<AspNetUserItem> GetCount(string roleName)
        {
            return ProcessQuery(_repository.Table.Where(c => c.AspNetRoles.Any(r => r.Name == roleName)).ToList());
        }
        public AspNetUserService(IUnitOfWorkAsync unitOfWork, IAspNetUserRepository repository)
        {
            _unitOfWork = unitOfWork;
            this._repository = repository;

        }

        public void Create(AspNetUserModel model, out string id)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                id = "";

                var passwordHash = new PasswordHasher();
                var password = passwordHash.HashPassword(model.Password);

                var entity = Mapper.Map<AspNetUserModel, AspNetUser>(model);
                entity.PasswordHash = password;
                entity.SecurityStamp = Guid.NewGuid().ToString();
                entity.Id = Guid.NewGuid().ToString();
                _repository.Insert(entity);

                /*var repository = _repository.GetRepository<IdentityUserRole>();
                var reposRole = _repository.GetRepository<AspNetRole>();
                repository.Insert(new IdentityUserRole()
                {
                    UserId = entity.Id,
                    RoleId = reposRole.Find(c=> c.Name == model.RoleName).Id
                });*/

                id = entity.Id;

                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }
        public void Delete(string id)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var entity = GetAspNetUserEntity(id);
                _repository.Delete(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public AspNetUserDetail GetDetail(string id)
        {
            var entity = GetAspNetUserEntity(id);
            return Mapper.Map<AspNetUser, AspNetUserDetail>(entity);
        }

        public AspNetUserItem GetItem(string id)
        {
            var entity = GetAspNetUserEntity(id);
            return Mapper.Map<AspNetUser, AspNetUserItem>(entity);
        }
        private static IEnumerable<AspNetUserItem> ProcessQuery(IEnumerable<AspNetUser> entities)
        {
            return Mapper.Map<IEnumerable<AspNetUser>, List<AspNetUserItem>>(entities);
        }

        public void Update(AspNetUserModel model, int currentAspNetUserId)
        {

            try
            {
                _unitOfWork.BeginTransaction();
                var userProfile = GetAspNetUserEntity(model.Id);
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
        private AspNetUser GetAspNetUserEntity(string id)
        {
            return _repository.Find(id);

        }
        public AspNetUserModel GetAspNetUser(string userId)
        {
            var entity = GetAspNetUserEntity(userId);
            return Mapper.Map<AspNetUser, AspNetUserModel>(entity);
        }

        public bool NameExist(AspNetUserModel brand)
        {
            return _repository.NameExist(brand);
        }

        public List<string> CreateBulk(List<AspNetUserModel> models)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                List<string> idsList = new List<string>();

                foreach (var model in models)
                {
                    var passwordHash = new PasswordHasher();
                    var password = passwordHash.HashPassword(model.Password);

                    var entity = Mapper.Map<AspNetUserModel, AspNetUser>(model);
                    entity.PasswordHash = password;
                    entity.SecurityStamp = Guid.NewGuid().ToString();
                    entity.Id = Guid.NewGuid().ToString();
                    _repository.Insert(entity);

                    idsList.Add(entity.Id);
                }

                _unitOfWork.Commit();
                return idsList;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public AspNetUserModel GetStudentId(string matricNumber)
        {
            return GetCount(Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student))
                .FirstOrDefault(c => c.MatricNumber == matricNumber);

        }
    }
}

