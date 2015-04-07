using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VacationLocation.Models
{
    public class Vacation
    {
        int ID { get; set; }
        string location {get; set; }
        double average_price {get; set; }
    }

    public class VacationDBContext : DbContext
    {
        public DbSet<Vacation> Vacations { get; set; }
    }
}