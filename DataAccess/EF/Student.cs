namespace DataAccess.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public Student()
        {
            CreatedAt = DateTime.UtcNow;

        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int SectionId { get; set; }

        public int LevelId { get; set; }

        [Required]
        [StringLength(50)]
        public string MatricNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual Level Level { get; set; }

        public virtual Section Section { get; set; }
    }
}
