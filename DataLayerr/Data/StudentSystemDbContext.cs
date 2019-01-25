namespace StudentSystem.Data
{
    using DataLayer.Models;

    using Microsoft.EntityFrameworkCore;

    using StudentSystem.Models;

    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext(DbContextOptions<StudentSystemDbContext> options)
            : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Mark> Marks { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Teacher> Teacher { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentSubjectMark>()
                .HasKey(sjm => new { sjm.StudentId, sjm.SubjectId, sjm.MarkId });
            modelBuilder.Entity<StudentSubjectMark>()
                .HasOne(sjm => sjm.Student)
                .WithMany(s => s.StudentSubjectMarks)
                .HasForeignKey(sjm => sjm.StudentId);
            modelBuilder.Entity<StudentSubjectMark>()
                .HasOne(sjm => sjm.Subject)
                .WithMany(j => j.StudentSubjectMarks)
                .HasForeignKey(sjm => sjm.SubjectId);
            modelBuilder.Entity<StudentSubjectMark>()
                .HasOne(sjm => sjm.Mark)
                .WithMany(m => m.StudentSubjectMarks)
                .HasForeignKey(sjm => sjm.MarkId);
        }
    }
}