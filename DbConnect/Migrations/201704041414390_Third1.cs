namespace DbConnect
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.User", new[] { "UserName" });
            AlterColumn("dbo.User", "UserName", c => c.String(nullable: false, maxLength: 255, unicode: false));
            CreateIndex("dbo.User", "UserName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.User", new[] { "UserName" });
            AlterColumn("dbo.User", "UserName", c => c.String(nullable: false, maxLength: 20, unicode: false));
            CreateIndex("dbo.User", "UserName", unique: true);
        }
    }
}
