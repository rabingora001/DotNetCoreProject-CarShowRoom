using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreProject1.Models;
using DotNetCoreProject1.Services;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreProject1.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreProject1.Controllers
{
    public class CarController : Controller
    {

        //Database(EntityFramework) for dependecy injection in constructor
        private MyDbContext _myContext;

        //this is not used anyomore.
        //private ICarData myCars = new CarData();

        //contructor method with dependency injection. Dependency injection will give reference to reference.
        public CarController(MyDbContext context) // we can also inject more DI in this contructor method seperaed by comma.
        {
            _myContext = context;
        }
        //constructor with dependency injection.
        //public CarController(ICarData carsData)
        //{
        //    myCars = carsData;
        //}

        //Show all cars
        public IActionResult ShowAllCars()
        {
            //return View(myCars.AllCars);
            return View(_myContext.carsTable.ToList());

        }

        //show details of a car
        public IActionResult ShowCarDetails(int id)
        {

            //foreach (var car in myCars.AllCars) {
            //    if (car.Id == id)
            //    {
            //        return View(car);
            //    }
            //}

            //return NotFound(); //404 error

            //search the movie with given Id.
            Car found = _myContext.carsTable.Find(id);
            if(found != null)
            {
                return View(found);
            }
            else
            {
                return NotFound(); //404 error
            }

        }

        //Add new car get request to display the add form.//Restrics to Get request.
        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }

        //Add new car post request to submit the add form. Restricts to post request, even with the same method name.
        [HttpPost]
        public IActionResult AddCar(Car addedCar)
        {
            if(ModelState.IsValid)
            {
                //addedCar.Id = 0;    //find an unused Id

                //foreach(var car in myCars.AllCars)
                //{
                //    if(car.Id > addedCar.Id)
                //    {
                //        addedCar.Id = car.Id;
                //    }
                //}
                //addedCar.Id++;
                //myCars.AllCars.Add(addedCar);

                _myContext.carsTable.Add(addedCar);
                _myContext.SaveChanges(); //need to save the database.


                return RedirectToAction("ShowAllCars");
                
            }
            return View(); //else stays in the same view.
        }

        
        [HttpGet]   //Edit car.//restricts to get request
        public IActionResult EditCar(int id)
        {

            //same as in showdetails method. search for the car with the given ID
            //for (int i = 0; i < myCars.AllCars.Count; i++)
            //    if (myCars.AllCars[i].Id == id)
            //    {
            //        return View(myCars.AllCars[i]);
            //    }

            Car found = _myContext.carsTable.Find(id);
            if(found != null)
            {
                return View(found);
            }
            else
            {
                //else
                return NotFound(); //404 error.else stays in the same view.
            }

        }


        [HttpPost]
        public IActionResult EditCar(int id, Car editedCar)
        {

            if (ModelState.IsValid)
            {
                //for (int i = 0; i < myCars.AllCars.Count; i++)
                //    if (myCars.AllCars[i].Id == id)
                //    {

                //        //found it
                //        myCars.AllCars[i].CarModel = editedCar.CarModel;
                //        myCars.AllCars[i].CarType = editedCar.CarType;
                //        myCars.AllCars[i].ReleaseDate = editedCar.ReleaseDate;
                //        myCars.AllCars[i].ReviewScore = editedCar.ReviewScore;
                //        myCars.AllCars[i].AvailableInMarket = editedCar.AvailableInMarket;
                //        myCars.AllCars[i].Description = editedCar.Description;
                //        return RedirectToAction("ShowAllCars");
                //    }


                Car oldCar = _myContext.carsTable.Find(id);

                if(oldCar !=null)
                {
                    oldCar.CarModel = editedCar.CarModel;
                    oldCar.CarType = editedCar.CarType;
                    oldCar.ReleaseDate = editedCar.ReleaseDate;
                    oldCar.ReviewScore = editedCar.ReviewScore;
                    oldCar.AvailableInMarket = editedCar.AvailableInMarket;
                    oldCar.Description = editedCar.Description;

                    //update the oldcar and save the database
                    _myContext.carsTable.Update(oldCar);
                    _myContext.SaveChanges();

                    return RedirectToAction("ShowAllCars");
                }
                

                return NotFound(); //404 error// throw new Exception("Bad request ... the ID doesn't exist, so we can't edit it!!!");
            }
           
            return View();
        }
       

        //delete car
        public IActionResult DeleteCar(int id)
        {
            //foreach(var car in myCars.AllCars)
            //{
            //    if(car.Id == id) {
            //        myCars.AllCars.Remove(car);
            //        return RedirectToAction("ShowAllCars");
            //    }
            //}

            Car oldCar = _myContext.carsTable.Find(id);

            if(oldCar != null)
            {
                _myContext.carsTable.Remove(oldCar);
                _myContext.SaveChanges();

                return RedirectToAction("ShowAllCars");
            }

            return Content("The car is not found!");
        }

    }
}
