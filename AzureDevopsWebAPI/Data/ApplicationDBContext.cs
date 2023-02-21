using AzureDevopsWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AzureDevopsWebAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext( DbContextOptions<ApplicationDBContext> options)
            : base(options) { }

        public DbSet<AccessLevel> AccessLevels { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<ChangeLog> ChangeLogs  { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessLevel>().HasData(
                    new AccessLevel { Id = 1, Value = "Project Manager" },
                    new AccessLevel { Id = 2, Value = "Lead Developers" },
                    new AccessLevel { Id = 3, Value = "Senior Developers" },
                    new AccessLevel { Id = 4, Value = "Mid-Level Developers" },
                    new AccessLevel { Id = 5, Value = "Junior Developers" },
                    new AccessLevel { Id = 6, Value = "Trainee Developers" },
                    new AccessLevel { Id = 7, Value = "Everyone" }
                );

            modelBuilder.Entity<Project>().HasData(
                    new Project { Id = 1, Name = "Fin-Statements Software Review", AccessLevelId = 1},
                    new Project { Id = 2, Name = "Financials Database Design", AccessLevelId = 2},
                    new Project { Id = 3, Name = "Asset-Management System Audit", AccessLevelId = 7},
                    new Project { Id = 4, Name = "Payroll Software UI Developmet", AccessLevelId = 5},
                    new Project { Id = 5, Name = "Customer Balance API Review", AccessLevelId = 5}
                );

            modelBuilder.Entity<Individual>().HasData(
                    new Individual { Id = 221028080, AccessLevelId = 1, Email = "221028080@students.nust.na", Password = "0000" },
                    new Individual { Id = 217030203, AccessLevelId = 2,  Email = "217030203@students.nust.na", Password = "0000" },
                    new Individual { Id = 221128220, AccessLevelId = 6,  Email = "221128220@students.nust.na", Password = "0000" },
                    new Individual { Id = 220130051, AccessLevelId = 3,  Email = "220130051@students.nust.na" , Password = "0000" }
                );

            modelBuilder.Entity<ItemType>().HasData(
                    new ItemType { Id = 1, Value = "Planning & Analysis" },
                    new ItemType { Id = 2, Value = "System Design"},
                    new ItemType { Id = 3, Value = "Development"},
                    new ItemType { Id = 4, Value = "Verification & Testing"},
                    new ItemType { Id = 5, Value = "Documentation"},
                    new ItemType { Id = 6, Value = "System Audit"}
                );

            modelBuilder.Entity<ChangeLog>().HasData(
                    new ChangeLog { Id = 3, IndividualId = 220130051, ProjectId = 3, StartDateTime = new DateTime(2023, 02, 17, 13, 47, 40), EndDateTime = new DateTime(2023, 02, 18, 2, 40, 0), Summary = "Auditing Financial Statements" }
                );
        }
    }

}
