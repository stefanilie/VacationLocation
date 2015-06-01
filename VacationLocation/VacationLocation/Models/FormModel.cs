using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacationLocation.Models
{
    public class FormModel
    {
        [Required]
        public int age { get; set; }
        
        [Required]
        public bool hasKids { get; set; }

        [Required]
        public string birthPlace { get; set; }

        [Required]
        public string climate { get; set; }

        [Required]
        public string residencePlace { get; set; }

        [Required]
        public bool isSingle { get; set; }

        [Required]
        public string cityType { get; set; }
        
        //test variable to show wether the post worked or not.
        public string resultLabel;
    }
}