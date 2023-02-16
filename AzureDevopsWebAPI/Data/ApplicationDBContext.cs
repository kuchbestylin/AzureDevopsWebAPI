using AzureDevopsWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AzureDevopsWebAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext( DbContextOptions<ApplicationDBContext> options)
            : base(options) { }

        public DbSet<Individual> Individuals { get; set; }
        public DbSet<ChangeLog> ChangeLogs  { get; set; }
        public DbSet<Project> Projects { get; set; }
    }

}
