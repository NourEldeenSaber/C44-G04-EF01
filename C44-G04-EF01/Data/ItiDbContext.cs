using C44_G04_EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G04_EF01.Data
{
    internal class ItiDbContext : DbContext
    {
        public ItiDbContext() : base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = MSI\\SQLEXPRESS; Database = ItiAssignment ; Trusted_Connection = True ; TrustServerCertificate = True ");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudentCourse> StudCourse { get; set; }
        public DbSet<CourseInstructor> InsCourse { get; set; }

    }
}
