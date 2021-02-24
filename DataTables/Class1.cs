using System;
using System.ComponentModel.DataAnnotations;

namespace DataTables
{
    public class CityDataTable
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
