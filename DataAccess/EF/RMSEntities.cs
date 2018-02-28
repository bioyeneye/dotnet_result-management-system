using DataAccess.BaseRepository;

namespace DataAccess.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RMSEntities : EntityFrameworkDataContext
    {
        public RMSEntities()
            : base("name=RMSEntities")
        {
        }

        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Semeter> Semeters { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Level>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Level)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Section)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Answer)
                .IsUnicode(false);
        }
    }
}
