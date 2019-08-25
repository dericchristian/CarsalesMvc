using CarSales.DataSource;
using CarSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarSales.Controllers
{
    public class CarsController : Controller
    {
        private VehicleTypeDataSource _vehicleTypeDataSource = null;
        private CarDataSource _carDataSource = null;

        public CarsController()
        {
            _vehicleTypeDataSource = VehicleTypeDataSource.GetInstance();
            _carDataSource = CarDataSource.GetInstance();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Car car)
        {
            if (car != null)
            {
                var vehicleType = _vehicleTypeDataSource.GetByName("Car");
                car.VehicleTypeId = vehicleType.Id;
                int id = _carDataSource.Add(car);
                return Json(new { success = true, result = id });
            }
            else
            {
                return Json(new { success = false });
            }
        }
    }
}