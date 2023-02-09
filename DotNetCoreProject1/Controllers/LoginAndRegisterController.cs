using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreProject1.Data;
using DotNetCoreProject1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreProject1.Controllers
{
    public class LoginAndRegister : Controller
    {
        //Entity framework(Database) for Depnedency Injection. You can access the tables of this database.
        private MyDbContext _myContext;

        //inject the service in the constructor so that it is creater eveytime its instance is called. 
        public LoginAndRegister(MyDbContext context)
        {
            _myContext = context;
        }

        //attribute routing. this is alternate routing to conventional routing. you can use either this routing or conventional routing.
        //[Route("Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
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

                

                return RedirectToAction("Index", "Home");

            }
            return View(); //else stays in the same view.
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            if (ModelState.IsValid)
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


                _myContext.usersTable.Add(register);
                _myContext.SaveChanges(); //need to save the database.
                return RedirectToAction("Login", "LoginAndRegister");

            }
            return View(); //else stays in the same view.
        }
    }
}
