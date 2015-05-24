using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VacationLocation.Models
{
    public class FormModel
    {
        public int Age { get; set; }

        public string hasKids { get; set; }

        public string birthPlace { get; set; }

        public string climate { get; set; }

        public string residencePlace { get; set; }

        public int selectedID { get; set; }

        //test variable to show wether the post worked or not.
        public string resultLabel;

        public System.Web.Mvc.SelectList status { get; set; }
    }
}