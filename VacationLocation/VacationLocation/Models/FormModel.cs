﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VacationLocation.Models
{
    public class FormModel
    {
        public int Varsta { get; set; }

        public int selectedID { get; set; }

        public System.Web.Mvc.SelectList status;
    }
}