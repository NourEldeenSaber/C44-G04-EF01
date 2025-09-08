using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{

    internal class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // old way
            //optionsBuilder.UseSqlServer("Data source = MSI\\SQLEXPRESS ; Intial Catlog = CompanyG01 ; Integrated Security : True");
            optionsBuilder.UseSqlServer("Server = MSI\\SQLEXPRESS; Database = CompanyG01 ; Trusted_Connection = True ; TrustServerCertificate = True ");
        }

        public DbSet<Employee> Employees { get; set; }
        /// public DbSet<Department> Departments { get; set; }
        /// public DbSet<Product> Products { get; set; }
        /// public DbSet<Project> Projects { get; set; }
    }
}
