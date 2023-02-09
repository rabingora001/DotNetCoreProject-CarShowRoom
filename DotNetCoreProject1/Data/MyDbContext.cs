using System;
using DotNetCoreProject1.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreProject1.Data
{
    //this is Entity Framework. It inherits form DcContxt class. this is mediator for SQL commands.
    public class MyDbContext : DbContext
    {

        //Dbset(table) = Entity table. here cars is a table containing Car entity from Model. This is same like List<Car>.
        public DbSet<Car> carsTable { get; set; }

        public DbSet<Register> usersTable { get; set; }

        //for another table(entity table)
        //public DbSet<SomeOtherEntityFromModel> EntityTable { get; set; }


        //need this constructor to pass DbContextOptions to the Startup.cs servises.
        //Here base option is passign to the parent class Dbcontxt.
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        //some defalt values in the database.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //some entries cars table
            modelBuilder.Entity<Car>().HasData(
                new Car {
                    Id = 1,
                    CarModel = "Toyota",
                    CarType = "Rav4",
                    ReviewScore = 9,
                    ReleaseDate = DateTime.Now,
                    AvailableInMarket = true,
                    Description = "nice car"
                },

                new Car
                {
                    Id = 2,
                    CarModel = "Nissan",
                    CarType = "Rouge",
                    ReviewScore = 8,
                    ReleaseDate = DateTime.Now,
                    AvailableInMarket = false,
                    Description = "nice car"
                }
            );

            //some entries for Register users' table
            modelBuilder.Entity<Register>().HasData(
                new Register
                {
                    RegisterId = 1,
                    FirstName = "FirstName1",
                    LastName = "LastName1",
                    Email = "user1@gmail.com",
                    Username = "user1",
                    Password = "1234",
                    ConfirmPassword = "1234",
                },

                new Register
                {
                    RegisterId = 2,
                    FirstName = "FirstName2",
                    LastName = "LastName2",
                    Email = "user2@gmail.com",
                    Username = "user2",
                    Password = "1234",
                    ConfirmPassword = "1234",
                }
            );
        }
    }
}
