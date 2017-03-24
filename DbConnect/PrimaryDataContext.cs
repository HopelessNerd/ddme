using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.Entity;
using DbConnect.Poco;

namespace DbConnect
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class PrimaryDataContext : DbContext
    {
        public PrimaryDataContext()
            : base("Server=localhost;Port=3306;Database=ddme;Uid=root;Pwd=123456789")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<TestResult> TestResult { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Pharmacist> Pharmacist { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }
    }
}
