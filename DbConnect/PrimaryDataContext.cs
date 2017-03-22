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
