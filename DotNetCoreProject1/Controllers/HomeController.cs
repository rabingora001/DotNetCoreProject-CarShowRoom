using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreProject1.Controllers
{
    public class HomeController : Controller
    {
        //default route.//Attribute route is alternate to conventional routing. You can use either or.
        //[Route("")]
        //[Route("main")]
        public IActionResult Index()
        {
            return View();
        }


        //ContentResult Route.
        //[Route("HomeShow/message")] //attribute routing. it is alternate to Startup route. cannot put both routes in the same method.
        public IActionResult Show()
        {
            return Content("This is from Home controller Index message.");
        }

        //redirects to Index method of Login controller. This has the attribute routing.
        public IActionResult RouteToLogin()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
