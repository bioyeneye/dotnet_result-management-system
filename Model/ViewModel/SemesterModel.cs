using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.ViewModel
{
    public class SemesterModel
    {
        public SemesterModel()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }

    }

    public class SemesterItem : SemesterModel
    {
    }

    public class SemesterDetail : SemesterItem
    {

    }
}
