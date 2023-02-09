using System;
using System.Collections.Generic;
using DotNetCoreProject1.Models;

namespace DotNetCoreProject1.Services
{

    //services are the datas of Models after creating instance of the model.
    public interface ICarData
    {
        List<Car> AllCars { get; set; }
    }
    
}
