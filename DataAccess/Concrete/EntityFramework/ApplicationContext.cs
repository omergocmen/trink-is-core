using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=trinkis;Trusted_Connection=true");
        }

        public DbSet<Category> Categories{ get; set; }
        public DbSet<Candidate> Candidates{ get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<JobAnnouncement> JobAnnouncements { get; set; }
        public DbSet<Application>Applications { get; set; }

   
    }
}