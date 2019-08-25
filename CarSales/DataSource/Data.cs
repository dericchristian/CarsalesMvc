using CarSales.Models;
using System.Collections.Generic;

namespace CarSales.DataSource
{
    public class Data
    {
        public static List<VehicleType> VehicleTypes { get; set; }
        public static List<BodyType> BodyTypes { get; set; }
        public static List<Car> Cars { get; set; }

        public static void Initialize()
        {
            VehicleTypes = new List<VehicleType>() { new VehicleType() { Id = 1, Name = "Car" } };
            BodyTypes = new List<BodyType>() {
                new BodyType() { Id = 1, Name = "Hatch Back" },
                new BodyType() { Id = 2, Name = "Sedan" }
            };
            Cars = new List<Car>();
        }
    }
}