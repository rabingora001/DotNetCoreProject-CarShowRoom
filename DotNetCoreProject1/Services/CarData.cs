using System;
using System.Collections.Generic;
using DotNetCoreProject1.Models;

namespace DotNetCoreProject1.Services
{
    //services are the datas of Models after creating instance of the model.
    //no use after using a database.
    public class CarData : ICarData
    {
        public List<Car> AllCars { set; get; }

        public CarData()
        {
            AllCars = new List<Car>();

            AllCars.Add(new Car() { Id = 0, CarModel = "Toyota", CarType = "Rav4", ReviewScore = 9.5, ReleaseDate = DateTime.Now, AvailableInMarket = true, Description="nice car"});
            AllCars.Add(new Car() { Id = 1, CarModel = "Nissan", CarType = "Rouge", ReviewScore = 9, ReleaseDate = DateTime.Now, AvailableInMarket = true, Description = "nice car" });
            AllCars.Add(new Car() { Id = 2, CarModel = "Ravian", CarType = "Air", ReviewScore = 8, ReleaseDate = DateTime.Now, AvailableInMarket = false, Description = "nice car" });
            AllCars.Add(new Car() { Id = 3, CarModel = "Hyundai", CarType = "Palasaid", ReviewScore = 7, ReleaseDate = DateTime.Now, AvailableInMarket = true, Description = "nice car" });
            AllCars.Add(new Car() { Id = 4, CarModel = "Lucid", CarType = "Luxury", ReviewScore = 10, ReleaseDate = DateTime.Now, AvailableInMarket = false, Description = "nice car" });

        }

        
    }
}
