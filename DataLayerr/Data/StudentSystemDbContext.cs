namespace StudentSystem.Data
{
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
    }
}