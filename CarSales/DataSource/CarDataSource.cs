using CarSales.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarSales.DataSource
{
    public class CarDataSource
    {
        private static CarDataSource _instance = null;
        private CarDataSource() { }

        /**
         * Gets single instance
         */
        public static CarDataSource GetInstance()
        {
            if(_instance == null)
            {
                _instance = new CarDataSource();
            }
            return _instance;
        }

        public List<Car> GetAll()
        {
            var data = Data.Cars;
            return data;
        }

        public Car GetById(int id)
        {
            var data = Data.Cars.FirstOrDefault(i => i.Id == id);
            return data;
        }

        public int Add(Car car)
        {
            var maxId = Data.Cars.Any() ? Data.Cars.Max(i => i.Id) : 0;
            car.Id = ++maxId;
            Data.Cars.Add(car);
            return maxId;
        }
    }
}