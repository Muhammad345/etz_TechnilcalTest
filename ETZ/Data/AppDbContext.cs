using ETZ.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETZ.ViewModel;

namespace ETZ.Data
{
    public class  AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Position> Positions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Position>().HasData(new Position {  Id = 1, Description = "Account Executive" });
            modelBuilder.Entity<Position>().HasData(new Position { Id = 2, Description = "Business Analyst" });
            modelBuilder.Entity<Position>().HasData(new Position { Id = 3, Description = "Risk Manager" });
            modelBuilder.Entity<Position>().HasData(new Position { Id = 4, Description = "Business Manager" });

        }

        }
    }
