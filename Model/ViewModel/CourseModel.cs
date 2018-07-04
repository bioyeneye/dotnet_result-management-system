using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.ViewModel
{
    public class CourseModel
    {
        public CourseModel()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int Unit { get; set; }

        public int LevelId { get; set; }

        public int SemesterId { get; set; }

        public DateTime CreatedAt { get; set; }

    }

    public class CourseItem : CourseModel
    {
        public string LevelName { get; set; }
        public string SemeterName { get; set; }
    }

    public class CourseDetail : CourseItem
    {

    }

    public class CourseTemplateDownloadModel
    {
        public string Code { get; set; }
        public int Unit { get; set; }
        public string Title { get; set; }
    }
}
