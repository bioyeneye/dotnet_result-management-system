namespace DataAccess.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Semeter")]
    public partial class Semeter
    {
        public Semeter()
        {
            CreatedAt = DateTime.UtcNow;
        }
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
