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
    public interface IResultService
    {
        IEnumerable<ResultItem> GetCount();
        void Create(ResultModel model, int currentUserId);
        void Delete(int id);
        void Update(ResultModel model, int currentUserId);
        ResultItem GetItem(int id);
        ResultModel GetResult(int userId);
        ResultDetail GetDetail(int id);
        IEnumerable<ResultSingleStudentTemplateDownloadModel> DownloadReportResultSingleStudent(int levelId, int semesterId);
        void CreateBulk(List<ResultModel> results);
        ResultModel CanSaveResult(string matricNumberId, int courseModelId);
        IEnumerable<ResultSingleCourseTemplateDownloadModel> DownloadReportResultSingleCourse();
        IEnumerable<ResultSingleCourseTemplateDownloadModel> GetAllSingleCourse(int course);
        void UpdateBulk(List<ResultModel> resultModels);
        ResultModel GetByMatricNumberCourseId(string matricNumber, int course);
        List<ResultSingleStudentTemplateDownloadModel> GetStudentResultForSemester(string studentId, int levelId, int semesterId);
        ResultModel GetByMatricNumberCourseCode(string studentMatricNumber, string courseCode);
        SemesterResultModel StudentSemesterResult(string matricNumber, int level, int semester);
    }
    public class ResultService : IResultService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;
        private readonly IResultRepository _resultRepository;

        public IEnumerable<ResultItem> GetCount()
        {
            return ProcessQuery(_resultRepository.Table.ToList());
        }
        public ResultService(IUnitOfWorkAsync unitOfWork, IResultRepository brandRepository)
        {
            _unitOfWork = unitOfWork;
            _resultRepository = brandRepository;

        }

        public void Create(ResultModel model, int currentUserId)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var entity = Mapper.Map<ResultModel, Result>(model);
                entity.CreatedAt = DateTime.Now;
                _resultRepository.Insert(entity);
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
                var entity = GetResultEntity(id);
                _resultRepository.Delete(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public ResultDetail GetDetail(int id)
        {
            var entity = GetResultEntity(id);
            return Mapper.Map<Result, ResultDetail>(entity);
        }

        public IEnumerable<ResultSingleStudentTemplateDownloadModel> DownloadReportResultSingleStudent(int levelId, int semesterId)
        {
            var courseRepository = _resultRepository.GetRepository<Course>();
            var courses = courseRepository.Table.Where(c => c.LevelId == levelId && c.SemesterId == semesterId).ToList();

            var returnValues = courses.Select(c => new ResultSingleStudentTemplateDownloadModel()
            {
                CourseCode = c.Code,
                Score = 0
            });

            return returnValues;
        }

        public void CreateBulk(List<ResultModel> results)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var entity = Mapper.Map<IEnumerable<ResultModel>, List<Result>>(results);
                _resultRepository.InsertRange(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public ResultModel CanSaveResult(string matricNumberId, int courseModelId)
        {
            var entity = _resultRepository.Table.FirstOrDefault(c => c.StudentId == matricNumberId && c.CourseId == courseModelId);
            return Mapper.Map<Result, ResultModel>(entity);
        }

        public IEnumerable<ResultSingleCourseTemplateDownloadModel> DownloadReportResultSingleCourse()
        {
            try
            {
                var roleName = Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student);
                var userRepository = _resultRepository.GetRepository<AspNetUser>();
                var courses = userRepository.Table.Where(c => c.AspNetRoles.Any(r => r.Name == roleName)).ToList();

                var returnValues = courses.Select(c => new ResultSingleCourseTemplateDownloadModel()
                {
                    MatricNumber = c.MatricNumber,
                    Score = 0
                });

                return returnValues;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<ResultSingleCourseTemplateDownloadModel> GetAllSingleCourse(int course)
        {
            try
            {

                var courses = _resultRepository.Table.Where(c => c.CourseId == course).ToList();

                var returnValues = courses.Select(c => new ResultSingleCourseTemplateDownloadModel()
                {
                    MatricNumber = c.AspNetUser.MatricNumber,
                    Score = c.Score
                }).ToList();

                return returnValues;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateBulk(List<ResultModel> resultModels)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                foreach (var model in resultModels)
                {
                    var entity = _resultRepository.Find(model.Id);
                    Mapper.Map(model, entity);
                    _resultRepository.Update(entity);
                }
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public ResultModel GetByMatricNumberCourseId(string matricNumber, int course)
        {
            try
            {
                var entity = _resultRepository.Table.FirstOrDefault(c =>
                    c.CourseId == course && c.AspNetUser.MatricNumber == matricNumber);
                return Mapper.Map<Result, ResultModel>(entity);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<ResultSingleStudentTemplateDownloadModel> GetStudentResultForSemester(string studentId, int levelId, int semesterId)
        {
            try
            {

                var courses = _resultRepository.Table.Where(c => c.StudentId == studentId && c.Course.LevelId == levelId && c.Course.SemesterId == semesterId).ToList();
                var returnValues = courses.Select(c => new ResultSingleStudentTemplateDownloadModel()
                {
                    CourseCode = c.Course.Code,
                    Score = c.Score
                }).ToList();

                return returnValues;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ResultModel GetByMatricNumberCourseCode(string studentMatricNumber, string courseCode)
        {
            try
            {
                var entity = _resultRepository.Table.FirstOrDefault(c =>
                    c.Course.Code.Equals(courseCode, StringComparison.OrdinalIgnoreCase) && c.AspNetUser.MatricNumber == studentMatricNumber);
                return Mapper.Map<Result, ResultModel>(entity);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }




        public ResultItem GetItem(int id)
        {
            var entity = GetResultEntity(id);
            return Mapper.Map<Result, ResultItem>(entity);
        }
        private static IEnumerable<ResultItem> ProcessQuery(IEnumerable<Result> entities)
        {
            return Mapper.Map<IEnumerable<Result>, List<ResultItem>>(entities);
        }

        public void Update(ResultModel model, int currentUserId)
        {

            try
            {
                _unitOfWork.BeginTransaction();

                var userProfile = GetResultEntity(model.Id);
                Mapper.Map(model, userProfile);
                _resultRepository.Update(userProfile);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }
        private Result GetResultEntity(int id)
        {
            return _resultRepository.Find(id);

        }
        public ResultModel GetResult(int userId)
        {
            var entity = GetResultEntity(userId);
            return Mapper.Map<Result, ResultModel>(entity);
        }

        public SemesterResultModel StudentSemesterResult(string matricNumber, int level, int semester)
        {
            var result = new SemesterResultModel();

            var resultInSemester = _resultRepository.Table.Where(c =>
                c.StudentId.Equals(matricNumber, StringComparison.OrdinalIgnoreCase) && c.Course.LevelId == level &&
                c.Course.SemesterId == semester).ToList();

            if (!resultInSemester.Any()) return null;

            var firstDetail = resultInSemester[0];
            result.StudentDetail = new ReportStudentDetail
            {
                Level = firstDetail.Course?.Level?.Name,
                Semester = firstDetail.Course?.Semeter.Name,
                Name = $"{firstDetail.AspNetUser.FirstName} {firstDetail.AspNetUser.LastName}",
                MatricNumber = firstDetail.AspNetUser.MatricNumber,
                Session = firstDetail.Course?.Level?.Sections.ToList()[0].Name,
            };


            result.SemesterCourse = resultInSemester.Select(c => new ReportStudentSemesterCourse
            {
                Score = c.Score,
                Unit = c.Course.Unit,
                CourseTitle = c.Course.Title,
                CourseCode = c.Course.Code,

            }).ToList();

            int sectionUnit = 0;
            int sectionScore = 0;
            int initialSemester = semester;
            for (int i = level; i >= 1; i--)
            {
                for (int j = initialSemester; j > 0; j--)
                {
                    var resultInSection = _resultRepository.Table.Where(c =>
                        c.StudentId.Equals(matricNumber, StringComparison.OrdinalIgnoreCase) && c.Course.LevelId == i &&
                        c.Course.SemesterId == j).ToList();

                    sectionUnit += resultInSection.Sum(c => c.Course.Unit);
                    sectionScore += resultInSection.Sum(c => ProcessScore(c.Score) * c.Course.Unit);
                }

                initialSemester = 2;
            }

            double cGPA = sectionScore / (double) sectionUnit;


            int semesterUnit = resultInSemester.Sum(c => c.Course.Unit);
            int semesterScore = resultInSemester.Sum(c => ProcessScore(c.Score) * c.Course.Unit);
            double semesterGP = semesterScore / (double)semesterUnit;

            result.GradeDetail = new ReportGradeDetail
            {
                SemesterGPA = semesterGP.ToString("F2"),
                SemesterTotalPoints = semesterScore.ToString(),
                SemesterTotalUnits = semesterUnit.ToString(),
                CummulativeGPA = cGPA.ToString("F2"),
                CummulativeTotalPoint = sectionScore.ToString(),
                CummulativeTotalUnits = sectionUnit.ToString()
            };

            return result;
        }

        private int ProcessScore(int score)
        {
            int grade = 0;
            if (score >= 70 && score <= 100)
            {
                grade = 5;
            }
            else if (score > 59 && score < 70)
            {
                grade = 4;
            }
            else if (score > 49 && score < 60)
            {
                grade = 3;
            }
            else if (score > 44 && score < 50)
            {
                grade = 2;
            }
            else if (score >= 40 && score < 45)
            {
                grade = 1;
            }
            else
            {
                grade = 0;
            }

            return grade;
        }
    }
}

