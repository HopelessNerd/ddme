namespace DbConnect
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestResult", "Waist", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TestResult", "Waist");
        }
    }
}
