using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace projectmodels
{
   public class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        //public virtual School School { get; set; }

        public virtual IEnumerable<Student> Students { get; set; }
    }
}
