namespace DbConnect
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                        StartTime = c.DateTime(nullable: false, precision: 0),
                        EndTime = c.DateTime(nullable: false, precision: 0),
                        IsApproved = c.Boolean(nullable: false),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctor", t => t.DoctorId)
                .ForeignKey("dbo.Patient", t => t.PatientId)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Doctor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 25, unicode: false),
                        MiddleName = c.String(maxLength: 25, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 25, unicode: false),
                        MobileNo = c.String(maxLength: 20, unicode: false),
                        LandLineNo = c.String(maxLength: 50, unicode: false),
                        AlternativeNo = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 254, unicode: false),
                        Address = c.String(maxLength: 150, unicode: false),
                        Country = c.String(maxLength: 25, unicode: false),
                        Gender = c.Int(nullable: false),
                        Speciality = c.String(maxLength: 40, unicode: false),
                        Qualifications = c.String(maxLength: 40, unicode: false),
                        LastUpdatedDate = c.DateTime(nullable: false, precision: 0),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Prescription",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prescribe = c.String(maxLength: 50, unicode: false),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                        File1 = c.String(maxLength: 50, unicode: false),
                        File2 = c.String(maxLength: 50, unicode: false),
                        Note = c.String(maxLength: 50, unicode: false),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctor", t => t.DoctorId)
                .ForeignKey("dbo.Patient", t => t.PatientId)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 25, unicode: false),
                        MiddleName = c.String(maxLength: 25, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 25, unicode: false),
                        MobileNo = c.String(maxLength: 20, unicode: false),
                        AlternativeNo = c.String(maxLength: 20, unicode: false),
                        LandLineNo = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 254, unicode: false),
                        Address = c.String(maxLength: 150, unicode: false),
                        Country = c.String(maxLength: 25, unicode: false),
                        Gender = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false, precision: 0),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                        LastUpdatedDate = c.DateTime(nullable: false, precision: 0),
                        Ethnicity = c.String(maxLength: 25, unicode: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, unicode: false),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                        StartTime = c.DateTime(nullable: false, precision: 0),
                        EndTime = c.DateTime(nullable: false, precision: 0),
                        Description = c.String(maxLength: 50, unicode: false),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patient", t => t.PatientId)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.TestResult",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50, unicode: false),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                        Weight = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        IsDiagnosedWithBP = c.Boolean(nullable: false),
                        AreRelativesDiagnosed = c.Boolean(nullable: false),
                        IsPhysicallyActive = c.Boolean(nullable: false),
                        IsGestationalDiabetes = c.Boolean(nullable: false),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patient", t => t.PatientId)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 20, unicode: false),
                        Description = c.String(maxLength: 50, unicode: false),
                        Password = c.String(maxLength: 50, unicode: false),
                        role = c.Int(nullable: false),
                        LastUpdateDate = c.DateTime(nullable: false, precision: 0),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true);
            
            CreateTable(
                "dbo.Pharmacist",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 25, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 25, unicode: false),
                        PharmacyName = c.String(nullable: false, maxLength: 25, unicode: false),
                        MobileNo = c.String(maxLength: 20, unicode: false),
                        LandLineNo = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 254, unicode: false),
                        Address = c.String(maxLength: 150, unicode: false),
                        country = c.String(maxLength: 25, unicode: false),
                        gender = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointment", "FK_Appointment_Patient_PatientId");
            DropForeignKey("dbo.Appointment", "FK_Appointment_Doctor_DoctorId");
            DropForeignKey("dbo.Doctor", "FK_Doctor_User_UserId");
            DropForeignKey("dbo.Prescription", "FK_Prescription_Patient_PatientId");
            DropForeignKey("dbo.Patient", "FK_Patient_User_UserId");
            DropForeignKey("dbo.Pharmacist", "FK_Pharmacist_User_UserId");
            DropForeignKey("dbo.TestResult", "FK_TestResult_Patient_PatientId");
            DropForeignKey("dbo.Event", "FK_Event_Patient_PatientId");
            DropForeignKey("dbo.Prescription", "FK_Prescription_Doctor_DoctorId");
            DropIndex("dbo.Pharmacist", new[] { "UserId" });
            DropIndex("dbo.User", new[] { "UserName" });
            DropIndex("dbo.TestResult", new[] { "PatientId" });
            DropIndex("dbo.Event", new[] { "PatientId" });
            DropIndex("dbo.Patient", new[] { "UserId" });
            DropIndex("dbo.Prescription", new[] { "DoctorId" });
            DropIndex("dbo.Prescription", new[] { "PatientId" });
            DropIndex("dbo.Doctor", new[] { "UserId" });
            DropIndex("dbo.Appointment", new[] { "DoctorId" });
            DropIndex("dbo.Appointment", new[] { "PatientId" });
            DropTable("dbo.Pharmacist");
            DropTable("dbo.User");
            DropTable("dbo.TestResult");
            DropTable("dbo.Event");
            DropTable("dbo.Patient");
            DropTable("dbo.Prescription");
            DropTable("dbo.Doctor");
            DropTable("dbo.Appointment");
        }
    }
}
