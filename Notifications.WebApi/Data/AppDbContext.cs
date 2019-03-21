using Microsoft.EntityFrameworkCore;
using Notifications.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notifications.WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Notifications;
                    Integrated Security=True;Connect Timeout=30;Encrypt=False;
                    TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                    MultiSubnetFailover=False"
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().Property(x => x.UserId).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<User>().HasData(
                  new User() { UserId = Guid.NewGuid(), UserName = "Mubeen" },
                  new User() { UserId = Guid.NewGuid(), UserName = "Tahir" },
                  new User() { UserId = Guid.NewGuid(), UserName = "Cheema" }
                  );
        }

    }
}
