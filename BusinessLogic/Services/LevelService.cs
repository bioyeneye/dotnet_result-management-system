using System;
using System.Collections.Generic;
using AutoMapper;
using DataAccess.BaseRepository;
using DataAccess.EF;
using DataAccess.Repository;
using Model.ViewModel;

namespace BusinessLogic.Services
{
    public interface ILevelService
    {
        IEnumerable<LevelItem> GetCount();
        void Create(LevelModel model, int currentUserId);
        void Delete(int id);
        void Update(LevelModel model, int currentUserId);
        LevelItem GetItem(int id);
        LevelModel GetLevel(int userId);
        LevelDetail GetDetail(int id);
        bool NameExist(LevelModel unit);
    }
    public class LevelService : ILevelService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;
        private readonly ILevelRepository _levelRepository;

        public IEnumerable<LevelItem> GetCount()
        {
            return ProcessQuery(_levelRepository.Table);
        }
        public LevelService(IUnitOfWorkAsync unitOfWork, ILevelRepository repository)
        {
            _unitOfWork = unitOfWork;
            _levelRepository = repository;

        }

        public void Create(LevelModel model, int currentUserId)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var entity = Mapper.Map<LevelModel, Level>(model);
                entity.CreatedAt = DateTime.Now;
                _levelRepository.Insert(entity);
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
                var entity = GetLevelEntity(id);
                _levelRepository.Delete(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public LevelDetail GetDetail(int id)
        {
            var entity = GetLevelEntity(id);
            return Mapper.Map<Level, LevelDetail>(entity);
        }

        public LevelItem GetItem(int id)
        {
            var entity = GetLevelEntity(id);
            return Mapper.Map<Level, LevelItem>(entity);
        }
        private static IEnumerable<LevelItem> ProcessQuery(IEnumerable<Level> entities)
        {
            return Mapper.Map<IEnumerable<Level>, IEnumerable<LevelItem>>(entities);
        }

        public void Update(LevelModel model, int currentUserId)
        {

            try
            {
                _unitOfWork.BeginTransaction();
                var userProfile = GetLevelEntity(model.Id);
                Mapper.Map(model, userProfile);
                _levelRepository.Update(userProfile);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }
        private Level GetLevelEntity(int id)
        {
            return _levelRepository.Find(id);

        }
        public LevelModel GetLevel(int userId)
        {
            var entity = GetLevelEntity(userId);
            return Mapper.Map<Level, LevelModel>(entity);
        }

        public bool NameExist(LevelModel brand)
        {
            return _levelRepository.NameExist(brand);
        }
    }
}

