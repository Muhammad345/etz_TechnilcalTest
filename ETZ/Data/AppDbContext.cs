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

            //seed Positions
            modelBuilder.Entity<Position>().HasData(new Position {  Id = 1, Description = "Account Executive" });
            modelBuilder.Entity<Position>().HasData(new Position { Id = 2, Description = "Business Analyst" });
            modelBuilder.Entity<Position>().HasData(new Position { Id = 3, Description = "Risk Manager" });
            modelBuilder.Entity<Position>().HasData(new Position { Id = 4, Description = "Business Manager" });

            //Seed Employee
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                DateOfBirth = DateTime.UtcNow.AddYears(-40),
                Location = "London",
                Sex = Common.Geneder.Male,
                Name = "Mr Peter Smith",
                Position_Id = 1
            },
            new Employee
            {
                Id = 2,
                DateOfBirth = DateTime.UtcNow.AddYears(-78),
                Location = "Sydney",
                Sex = Common.Geneder.Male,
                Name = "Mr Simon Dreyfus",
                Position_Id = 2
            },
            new Employee
            {
                Id = 3,
                DateOfBirth = DateTime.UtcNow.AddYears(-80),
                Location = "London",
                Sex = Common.Geneder.Female,
                Name = "Sally Elfish",
                Position_Id = 3
            });
        }

        }
    }
