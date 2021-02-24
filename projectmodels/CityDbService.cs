using DataTables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace projectmodels
{
   public class CityDbService
    {
        DrivingSchoolEntities drivingSchoolEntities;
        public CityDbService()
        {
            drivingSchoolEntities = new DrivingSchoolEntities();



        }
        public void AddCity(CityDataTable cityDataTable)
        {
            City city = new City()
            {
                Name = cityDataTable.Name

            };
            drivingSchoolEntities.City.Add(city);
            drivingSchoolEntities.SaveChanges();
        }
        public List<CityDataTable> List()
        {
            List<CityDataTable> cityDataTables;
            cityDataTables = (from recs in drivingSchoolEntities.City
                              select new CityDataTable
                              {
                                  Id = recs.Id,
                                  Name = recs.Name,
                              }).ToList();
            return cityDataTables;
        }
    }
}
