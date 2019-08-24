using CarSales.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarSales.Controllers
{
    public class HomeController : Controller
    {
        private VehicleTypeDataSource _vehicleTypeDataSource = null;

        public HomeController()
        {
            _vehicleTypeDataSource = VehicleTypeDataSource.GetInstance();
        }

        public ActionResult Index()
        {
            var model = _vehicleTypeDataSource.GetAll();
            return View(model);
        }
    }
}