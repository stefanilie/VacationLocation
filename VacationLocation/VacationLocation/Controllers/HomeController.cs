using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;
using System.Web;

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
        public ActionResult Form(Models.FormModel form)
        {
            return View(form);
        }

        [HttpPost]
        public ActionResult Form(Models.FormModel form, string Age, 
            string hasKids, string birthPlace, string climate, 
            string residencePlace, int selectedId, SelectList status)
        {
            //InsertStuffToDb(allParamsHere);
            List<SelectListItem> list = new List<SelectListItem>{
                new SelectListItem(){Value ="1", Text ="Single"},
                new SelectListItem(){Value= "2", Text="Intr-o Relatie"},
            };

            form = new Models.FormModel();
            form.resultLabel = Age + " / " + hasKids + " / " +
                birthPlace + " / " + climate + " / " + residencePlace + " / " +
                selectedId.ToString() + " / " + status.ToString();

            return View(form);
        }
    }
}