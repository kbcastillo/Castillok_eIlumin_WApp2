using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base ("SchoolContext")
        {
        }

        public DbSet<Employee> Students { get; set; }
        public DbSet<Promotion> Courses { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
