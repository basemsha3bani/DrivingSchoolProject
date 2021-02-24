using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace projectmodels
{
    public partial class DrivingSchoolEntities : DbContext
    {
        public DrivingSchoolEntities()
            : base("DrivingSchoolEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Student> AcademicInterviewRequests { get; set; }
        public virtual DbSet<School> School { get; set; }
      

        
    }

}
