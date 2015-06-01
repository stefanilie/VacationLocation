using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;
using System.Web;
using VacationLocation.Models;

namespace VacationLocation.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Form(Models.FormModel form)
        {
            if (ModelState.IsValid)
            {
                DestinationContext destContext = new DestinationContext();
                DestinationModel dest = destContext.Destinations.Single(emp => emp.climate == form.climate);
                Console.WriteLine(dest);
                return View("Thanks", dest);
            }
            else
            {
                return View();
            }
            //InsertStuffToDb(allParamsHere);
        }
    }
}