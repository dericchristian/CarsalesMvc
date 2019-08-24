using CarSales.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarSales.DataSource
{
    public class VehicleTypeDataSource
    {
        private static VehicleTypeDataSource _instance = null;
        private VehicleTypeDataSource() { }

        /**
         * Gets single instance
         */
        public static VehicleTypeDataSource GetInstance()
        {
            if(_instance == null)
            {
                _instance = new VehicleTypeDataSource();
            }
            return _instance;
        }

        public List<VehicleType> GetAll()
        {
            var data = Data.VehicleTypes;
            return data;
        }

        public VehicleType GetById(int id)
        {
            var data = Data.VehicleTypes.FirstOrDefault(i => i.Id == id);
            return data;
        }
    }
}