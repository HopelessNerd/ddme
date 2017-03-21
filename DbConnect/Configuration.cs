using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Migrations;

namespace DbConnect
{
    internal class Configuration : DbMigrationsConfiguration<PrimaryDataContext>
    {
        public Configuration()
        {
            CodeGenerator = new CustomCodeGenerator();
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }
    }
}
