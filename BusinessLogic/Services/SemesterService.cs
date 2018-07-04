using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataAccess.BaseRepository;
using DataAccess.EF;
using DataAccess.Repository;
using Model.ViewModel;

namespace BusinessLogic.Services
{
    public interface ISemesterService
    {
        IEnumerable<SemesterItem> GetCount();
        void Create(SemesterModel model, int currentUserId);
        void Delete(int id);
        void Update(SemesterModel model, int currentUserId);
        SemesterItem GetItem(int id);
        SemesterModel GetSemester(int userId);
        SemesterDetail GetDetail(int id);
        bool NameExist(SemesterModel unit);


        int GetSemesterId(string name);
    }
    public class SemesterService : ISemesterService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;
        private readonly ISemesterRepository _semesterRepository;

        public IEnumerable<SemesterItem> GetCount()
        {
            return ProcessQuery(_semesterRepository.Table);
        }
        public SemesterService(IUnitOfWorkAsync unitOfWork, ISemesterRepository repository)
        {
            _unitOfWork = unitOfWork;
            _semesterRepository = repository;

        }

        public void Create(SemesterModel model, int currentUserId)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var entity = Mapper.Map<SemesterModel, Semeter>(model);
                entity.CreatedAt = DateTime.Now;
                _semesterRepository.Insert(entity);
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
                var entity = GetSemesterEntity(id);
                _semesterRepository.Delete(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public SemesterDetail GetDetail(int id)
        {
            var entity = GetSemesterEntity(id);
            return Mapper.Map<Semeter, SemesterDetail>(entity);
        }

        public SemesterItem GetItem(int id)
        {
            var entity = GetSemesterEntity(id);
            return Mapper.Map<Semeter, SemesterItem>(entity);
        }
        private static IEnumerable<SemesterItem> ProcessQuery(IEnumerable<Semeter> entities)
        {
            return Mapper.Map<IEnumerable<Semeter>, List<SemesterItem>>(entities);
        }

        public void Update(SemesterModel model, int currentUserId)
        {

            try
            {
                _unitOfWork.BeginTransaction();
                var userProfile = GetSemesterEntity(model.Id);
                Mapper.Map(model, userProfile);
                _semesterRepository.Update(userProfile);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }
        private Semeter GetSemesterEntity(int id)
        {
            return _semesterRepository.Find(id);

        }
        public SemesterModel GetSemester(int userId)
        {
            var entity = GetSemesterEntity(userId);
            return Mapper.Map<Semeter, SemesterModel>(entity);
        }

        public bool NameExist(SemesterModel model)
        {
            return _semesterRepository.NameExist(model);
        }

        public int GetSemesterId(string name)
        {
            var id = _semesterRepository.Table.FirstOrDefault(c => c.Name == name)?.Id;
            if (id != null)
                return (int)id;

            return 0;
        }
    }
}

