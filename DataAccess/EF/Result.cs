namespace DataAccess.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Result")]
    public partial class Result
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public int SectionId { get; set; }

        [Required]
        [StringLength(128)]
        public string StudentId { get; set; }

        public int Score { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Course Course { get; set; }

        public virtual Section Section { get; set; }
    }
}
