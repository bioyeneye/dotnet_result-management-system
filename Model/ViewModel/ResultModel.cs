using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model.ViewModel
{
    public class ResultModel
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public int SectionId { get; set; }

        [Required]
        [StringLength(128)]
        public string StudentId { get; set; }

        public int Score { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public class ResultItem : ResultModel
    {
        public string LevelName { get; set; }
    }

    public class ResultDetail : ResultItem
    {

    }


    public class ResultSingleStudentTemplateDownloadModel
    {
        public string CourseCode { get; set; }

        public int Score { get; set; }

    }

    public class ResultSingleCourseTemplateDownloadModel
    {
        [Description("Matric Number")]
        public string MatricNumber { get; set; }

        public int Score { get; set; }
    }

    public class ResultSingleCourseTemplateDownloadModelComparer : IEqualityComparer<ResultSingleCourseTemplateDownloadModel>
    {
        public bool Equals(ResultSingleCourseTemplateDownloadModel x, ResultSingleCourseTemplateDownloadModel y)
        {
            if (x == null) return false;
            if (y == null) return false;
            return (x.MatricNumber.Equals(y.MatricNumber, StringComparison.OrdinalIgnoreCase) && x.Score == y.Score);
        }

        public int GetHashCode(ResultSingleCourseTemplateDownloadModel obj)
        {
            return obj.Score.GetHashCode();
        }
    }

    public class ResultSingleStudentTemplateDownloadModelComparer : IEqualityComparer<ResultSingleStudentTemplateDownloadModel>
    {
        public bool Equals(ResultSingleStudentTemplateDownloadModel x, ResultSingleStudentTemplateDownloadModel y)
        {
            if (x == null) return false;
            if (y == null) return false;
            return (x.CourseCode.Equals(y.CourseCode, StringComparison.OrdinalIgnoreCase) && x.Score == y.Score);
        }

        public int GetHashCode(ResultSingleStudentTemplateDownloadModel obj)
        {
            return obj.Score.GetHashCode();
        }
    }

    public class ReportStudentDetail
    {
        public string Name { get; set; }
        public string MatricNumber { get; set; }
        public string Session { get; set; }
        public string Semester { get; set; }
        public string Level { get; set; }
        public string Program { get; set; } = "BACHELOR OF SCIENCE (COMPUTER SCIENCE)";
    }

    public class ReportGradeDetail
    {
        public string SemesterTotalUnits { get; set; }
        public string SemesterTotalPoints { get; set; }
        public string SemesterGPA { get; set; }
        public string CummulativeTotalUnits { get; set; }
        public string CummulativeTotalPoint { get; set; }
        public string CummulativeGPA { get; set; }
    }

    public class ReportStudentSemesterCourse
    {
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public int Unit { get; set; }
        public int Score { get; set; }

        public char Grade => ProcessGrade(score: Score);

        private char ProcessGrade(int score)
        {
            char grade = 'F';
            if (score >= 70 && score <= 100)
            {
                grade = 'A';
            }
            else if (score > 59 && score < 70)
            {
                grade = 'B';
            }
            else if (score > 49 && score < 60)
            {
                grade = 'C';
            }
            else if (score > 44 && score < 50)
            {
                grade = 'D';
            }
            else if (score >= 40 && score < 45)
            {
                grade = 'E';
            }
            else
            {
                grade = 'F';
            }

            return grade;
        }
    }

    public class SemesterResultModel
    {
        public ReportStudentDetail StudentDetail { get; set; }
        public List<ReportStudentSemesterCourse> SemesterCourse { get; set; }
        public ReportGradeDetail GradeDetail { get; set; }
    }
}
