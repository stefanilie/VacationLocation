using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VacationLocation.Models
{
    public class DestinationContext : DbContext
    {
        public DbSet<FormModel> Destinations { get; set; }
    }

}