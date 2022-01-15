using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Hospital_Management_System.Models.DbContexts
{
    public class HSMDbContext : DbContext
    {
        //public HSMDbContext() : base("name=entities")
        //{ }
        public DbSet<Doctor> Doctors
        {
            get;
            set;
        }
        public DbSet<Appointment> Appointments
        {
            get;
            set;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
