using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreProject1.Controllers
{
    public class DashboardController : Controller
    {
        //Alternate routing optional instead of Startup.cs routing.// prefered routing in conventional routing from Startup.cs useMvc routing.
        //[Route("main/dashboard/page")]
        //[Route("dashboardpage")]
        public IActionResult DisplayDashboard()
        {
            return View();
        }

        //content result route.
        public IActionResult DisplayMessage(int id)
        {
            return Content($"This is form Dashboard controller DisplayMessage Action. The parameter passed is {id}");
        }
    }
}
