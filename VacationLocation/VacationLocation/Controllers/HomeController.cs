using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;

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

        public ActionResult Form(Models.FormModel form)
        {
            List<SelectListItem> list = new List<SelectListItem>{
                new SelectListItem(){Value ="1", Text ="Single"},
                new SelectListItem(){Value= "2", Text="Intr-o Relatie"},
            };

            form = new Models.FormModel();
            form.status = new SelectList(list, "Value", "Text");

            return View(form);
        }
    }
}