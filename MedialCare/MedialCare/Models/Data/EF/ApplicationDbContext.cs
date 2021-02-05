using Microsoft.EntityFrameworkCore;
using MedialCare.Models.Entities;
using MedialCare.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedialCare.Models.Data.Configurations;
using MedialCare.Models.Data.Entities;

namespace MedialCare.Models.EF
{
    public class ApplicationDbContext : DbContext
    {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PolicyOnEmployee> PolicyOnEmployees { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Policy> Policys { get; set; }
        public DbSet<FeedBack> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Configuration 
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PolicyConfiguration());
            modelBuilder.ApplyConfiguration(new PolicyOnEmployeeConfiguration());
            // Seed Database
            modelBuilder.Seed();
        }
    }
}
