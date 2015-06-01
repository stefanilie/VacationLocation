using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VacationLocation.Models
{
    [Table("Destinations")]
    public class DestinationModel
    {
        public int id { get; set; }

        public string city { get; set; }

        public string country { get; set; }

        public int population { get; set; }

        public string climate { get; set; }

        public int suitableForFamilies { get; set; }

        public int suitableForCouples { get; set; }

        public int minAge { get; set; }

        public int maxAge { get; set; }
    }
}