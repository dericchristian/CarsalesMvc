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
        private BodyTypeDataSource _bodyTypeDataSource = null;

        public HomeController()
        {
            _vehicleTypeDataSource = VehicleTypeDataSource.GetInstance();
            _bodyTypeDataSource = BodyTypeDataSource.GetInstance();
        }

        public ActionResult Index()
        {
            var model = _vehicleTypeDataSource.GetAll();
            return View(model);
        }

        public ActionResult AddVehicle(int typeId)
        {
            var vehicleType = _vehicleTypeDataSource.GetById(typeId);
            if (vehicleType != null && vehicleType.Name == "Car")
            {
                return RedirectToAction("Add", "Cars");
            }
            return new HttpStatusCodeResult(400);
        }

        public JsonResult GetBodyTypesJson()
        {
            var data = _bodyTypeDataSource.GetAll();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}