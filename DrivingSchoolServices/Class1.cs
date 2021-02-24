using System;
using System.Collections.Generic;
using DataTables;
using projectmodels;

namespace DrivingSchoolServices
{
    public class CityService
    {
        private CityDbService cityDbService;
        public CityService()
        {
            cityDbService = new CityDbService();
        }
        public void AddCity(CityDataTable cityDataTable)
        {

            cityDbService.AddCity(cityDataTable);
        }

        public List<CityDataTable> ListCity()
        {
            List<CityDataTable> list;
            list= cityDbService.List();
            return list;
        }

    }
}
