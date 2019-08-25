using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSales.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int VehicleTypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}