﻿using System;
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
               form.resultLabel = form.Age + " / " + form.hasKids + " / " +
               form.birthPlace + " / " + form.climate + " / " + form.residencePlace + " / " +
               form.isSingle + " / " + form.climate;

               return View("Thanks", form);
            }
            else
            {
                return View();
            }
            //InsertStuffToDb(allParamsHere);
        }
    }
}