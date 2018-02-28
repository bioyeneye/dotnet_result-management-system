using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataAccess.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public User()
        {
            CreatedAt = DateTime.UtcNow;
        }
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Column(TypeName = "text")]
        public string Question { get; set; }

        [Column(TypeName = "text")]
        public string Answer { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }
    }
}
