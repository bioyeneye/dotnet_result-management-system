using System.ComponentModel;

namespace DataAccess.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
            return (x.MatricNumber.Equals(y.MatricNumber, StringComparison.OrdinalIgnoreCase) && x.Score==y.Score);
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
}
