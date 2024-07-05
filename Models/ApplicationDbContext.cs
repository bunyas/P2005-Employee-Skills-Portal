using Microsoft.EntityFrameworkCore;

namespace P2005_Employee_Skills_Portal.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<StaffPages> StaffPages { get; set; }
        public DbSet<StaffSoftwareExpertisePage> StaffSoftwareExpertisePages { get; set; }
        public DbSet<StaffLanguagesPage> StaffLanguagesPages { get; set; }
        public DbSet<StaffProjectsPage> StaffProjectsPages { get; set; }
    }

}
