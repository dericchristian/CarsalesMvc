using CarSales.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CarSales.DataSource
{
    public class Data
    {
        public static List<VehicleType> VehicleTypes { get; set; }

        public static void Initialize()
        {
            VehicleTypes = new List<VehicleType>() { new VehicleType() { Id = 1, Name = "Car" } };
        }
    }
}