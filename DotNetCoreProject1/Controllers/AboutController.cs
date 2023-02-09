using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreProject1.Controllers
{
    public class AboutController : Controller
    {
        // GET: /<controller>/
        public IActionResult AboutPage()
        {

            ViewBag.Users = new Dictionary<string, int>();
            ViewBag.Users.Add("Rabin", 1);
            ViewBag.Users.Add("Alex", 3);
            ViewBag.Users.Add("Krsna", 7);

            //IList<string> places = new List<string>();
            //places.Add("Honolulu");
            //places.Add("Miami");
            //places.Add("Malibu");

            ViewData["Greeting"] = "Hello World!";
            return View();
        }
    }
}
