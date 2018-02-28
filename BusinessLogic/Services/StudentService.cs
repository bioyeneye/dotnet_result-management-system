using System;
using System.Collections.Generic;
using AutoMapper;
using DataAccess.BaseRepository;
using DataAccess.EF;
using DataAccess.Repository;
using Model.ViewModel;

namespace BusinessLogic.Services
{
    public interface IStudentService
    {
        IEnumerable<StudentItem> GetCount();
        void Create(StudentModel model, int currentUserId);
        void Delete(int id);
        void Update(StudentModel model, int currentUserId);
        StudentItem GetItem(int id);
        StudentModel GetStudent(int userId);
        StudentDetail GetDetail(int id);
        bool NameExist(StudentModel unit);
    }
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;
        private readonly IStudentRepository _repository;

        public IEnumerable<StudentItem> GetCount()
        {
            return ProcessQuery(_repository.Table);
        }
        public StudentService(IUnitOfWorkAsync unitOfWork, IStudentRepository repository)
        {
            _unitOfWork = unitOfWork;
            this._repository = repository;

        }

        public void Create(StudentModel model, int currentUserId)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var entity = Mapper.Map<StudentModel, Student>(model);
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
                var entity = GetStudentEntity(id);
                _repository.Delete(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public StudentDetail GetDetail(int id)
        {
            var entity = GetStudentEntity(id);
            return Mapper.Map<Student, StudentDetail>(entity);
        }

        public StudentItem GetItem(int id)
        {
            var entity = GetStudentEntity(id);
            return Mapper.Map<Student, StudentItem>(entity);
        }
        private static IEnumerable<StudentItem> ProcessQuery(IEnumerable<Student> entities)
        {
            return Mapper.Map<IEnumerable<Student>, IEnumerable<StudentItem>>(entities);
        }

        public void Update(StudentModel model, int currentUserId)
        {

            try
            {
                _unitOfWork.BeginTransaction();
                var userProfile = GetStudentEntity(model.Id);
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
        private Student GetStudentEntity(int id)
        {
            return _repository.Find(id);

        }
        public StudentModel GetStudent(int userId)
        {
            var entity = GetStudentEntity(userId);
            return Mapper.Map<Student, StudentModel>(entity);
        }

        public bool NameExist(StudentModel brand)
        {
            return _repository.NameExist(brand);
        }
    }
}

