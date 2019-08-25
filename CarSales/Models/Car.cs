using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSales.Models
{
    public class Car : Vehicle
    {
        public string Engine { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public int BodyTypeId { get; set; }
    }
}