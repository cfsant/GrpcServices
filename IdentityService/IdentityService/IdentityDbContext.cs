using Commons.Configurations;
using Commons.Entities;
using Commons.Enums;
using Entities.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace IdentityService
{
    public class IdentityDbContext : BaseDbContext<IdentityDbContext>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
            : base(options)
        {
        }

        public DbSet<Profile> Profile { get; set; }
        public DbSet<Session> Session { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("public");

            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
            modelBuilder.Entity<Profile>().HasData(new Profile
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                Password = "123",
                Roles = new string[1] { Roles.ADMIN }
            });

            
        }
    }
}