using System;
using System.Collections.Generic;
using AutoMapper;
using DataAccess.BaseRepository;
using DataAccess.EF;
using DataAccess.Repository;
using Model.ViewModel;

namespace BusinessLogic.Services
{
    public interface ISemeterService
    {
        IEnumerable<SemeterItem> GetCount();
        void Create(SemeterModel model, int currentUserId);
        void Delete(int id);
        void Update(SemeterModel model, int currentUserId);
        SemeterItem GetItem(int id);
        SemeterModel GetSemeter(int userId);
        SemeterDetail GetDetail(int id);
        bool NameExist(SemeterModel unit);
    }
    public class SemeterService : ISemeterService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;
        private readonly ISemesterRepository _semesterRepository;

        public IEnumerable<SemeterItem> GetCount()
        {
            return ProcessQuery(_semesterRepository.Table);
        }
        public SemeterService(IUnitOfWorkAsync unitOfWork, ISemesterRepository repository)
        {
            _unitOfWork = unitOfWork;
            _semesterRepository = repository;

        }

        public void Create(SemeterModel model, int currentUserId)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var entity = Mapper.Map<SemeterModel, Semeter>(model);
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
                var entity = GetSemeterEntity(id);
                _semesterRepository.Delete(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public SemeterDetail GetDetail(int id)
        {
            var entity = GetSemeterEntity(id);
            return Mapper.Map<Semeter, SemeterDetail>(entity);
        }

        public SemeterItem GetItem(int id)
        {
            var entity = GetSemeterEntity(id);
            return Mapper.Map<Semeter, SemeterItem>(entity);
        }
        private static IEnumerable<SemeterItem> ProcessQuery(IEnumerable<Semeter> entities)
        {
            return Mapper.Map<IEnumerable<Semeter>, IEnumerable<SemeterItem>>(entities);
        }

        public void Update(SemeterModel model, int currentUserId)
        {

            try
            {
                _unitOfWork.BeginTransaction();
                var userProfile = GetSemeterEntity(model.Id);
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
        private Semeter GetSemeterEntity(int id)
        {
            return _semesterRepository.Find(id);

        }
        public SemeterModel GetSemeter(int userId)
        {
            var entity = GetSemeterEntity(userId);
            return Mapper.Map<Semeter, SemeterModel>(entity);
        }

        public bool NameExist(SemeterModel brand)
        {
            return _semesterRepository.NameExist(brand);
        }
    }
}

