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
    public interface ICourseService
    {
        IEnumerable<CourseItem> GetCount();
        void Create(CourseModel model, int currentUserId);
        void Delete(int id);
        void Update(CourseModel model, int currentUserId);
        CourseItem GetItem(int id);
        CourseModel GetCourse(int userId);
        CourseDetail GetDetail(int id);
        bool NameExist(CourseModel unit);

        void CreateBulk(List<CourseModel> courseModels);
        CourseModel GetCourseByName(string courseCode);
        CourseModel CanSaveCourse(string code);
        List<ResultSingleStudentTemplateDownloadModel> GetCoursePerSemesterLevel(int levelId, int semesterId);
    }
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;
        private readonly ICourseRepository _levelRepository;

        public IEnumerable<CourseItem> GetCount()
        {
            return ProcessQuery(_levelRepository.Table.OrderBy(c=> c.LevelId).ToList());
        }
        public CourseService(IUnitOfWorkAsync unitOfWork, ICourseRepository repository)
        {
            _unitOfWork = unitOfWork;
            _levelRepository = repository;

        }

        public void Create(CourseModel model, int currentUserId)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var entity = Mapper.Map<CourseModel, Course>(model);
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
                var entity = GetCourseEntity(id);
                _levelRepository.Delete(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public CourseDetail GetDetail(int id)
        {
            var entity = GetCourseEntity(id);
            return Mapper.Map<Course, CourseDetail>(entity);
        }

        public CourseItem GetItem(int id)
        {
            var entity = GetCourseEntity(id);
            return Mapper.Map<Course, CourseItem>(entity);
        }
        private static IEnumerable<CourseItem> ProcessQuery(IEnumerable<Course> entities)
        {
            return Mapper.Map<IEnumerable<Course>, List<CourseItem>>(entities);
        }

        public void Update(CourseModel model, int currentUserId)
        {

            try
            {
                _unitOfWork.BeginTransaction();
                var userProfile = GetCourseEntity(model.Id);
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
        private Course GetCourseEntity(int id)
        {
            return _levelRepository.Find(id);

        }
        public CourseModel GetCourse(int userId)
        {
            var entity = GetCourseEntity(userId);
            return Mapper.Map<Course, CourseModel>(entity);
        }

        public bool NameExist(CourseModel model)
        {
            return _levelRepository.NameExist(model);
        }

        public void CreateBulk(List<CourseModel> courseModels)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var entity = Mapper.Map<IEnumerable<CourseModel>, List<Course>>(courseModels);
                _levelRepository.InsertRange(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public CourseModel GetCourseByName(string courseCode)
        {
            var course = _levelRepository.Table.FirstOrDefault(c => c.Code.Equals(courseCode, StringComparison.OrdinalIgnoreCase));
            return Mapper.Map<Course, CourseModel>(course);
        }

        public CourseModel CanSaveCourse(string code)
        {
            var entity =
                _levelRepository.Table.FirstOrDefault(c => c.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
            return Mapper.Map<Course, CourseModel>(entity);
        }

        public List<ResultSingleStudentTemplateDownloadModel> GetCoursePerSemesterLevel(int levelId, int semesterId)
        {
            var entities = _levelRepository.Table.Where(c => c.SemesterId == semesterId && c.LevelId == levelId).ToList();
            return entities.Select(c => new ResultSingleStudentTemplateDownloadModel
            {
                Score = 0,
                CourseCode = c.Code
            }).ToList();
        }
    }
}

