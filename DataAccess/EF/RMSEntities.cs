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

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Semeter> Semeters { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<StudentCourseAssign> StudentCourseAssigns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.StudentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Level>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Level)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Level>()
                .HasMany(e => e.Sections)
                .WithRequired(e => e.Level)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Level>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Level)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.Section)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Section)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.StudentCourseAssigns)
                .WithRequired(e => e.Section)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Semeter>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Semeter)
                .HasForeignKey(e => e.SemesterId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<Grade>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
