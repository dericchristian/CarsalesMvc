using CarSales.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarSales.DataSource
{
    public class BodyTypeDataSource
    {
        private static BodyTypeDataSource _instance = null;
        private BodyTypeDataSource() { }

        /**
         * Gets single instance
         */
        public static BodyTypeDataSource GetInstance()
        {
            if(_instance == null)
            {
                _instance = new BodyTypeDataSource();
            }
            return _instance;
        }

        public List<BodyType> GetAll()
        {
            var data = Data.BodyTypes;
            return data;
        }

        public BodyType GetById(int id)
        {
            var data = Data.BodyTypes.FirstOrDefault(i => i.Id == id);
            return data;
        }

        public BodyType GetByName(string name)
        {
            var data = Data.BodyTypes.FirstOrDefault(i => i.Name == name);
            return data;
        }
    }
}