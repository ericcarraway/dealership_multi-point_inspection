namespace Dealership.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_migration_ : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InspectionRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vin = c.String(nullable: false),
                        DateIn = c.DateTime(nullable: false),
                        OwnerId = c.Int(nullable: false),
                        Horn = c.Boolean(nullable: false),
                        Lights_Signals = c.Boolean(nullable: false),
                        WindshieldWiper = c.Boolean(nullable: false),
                        WindshieldGlass = c.Boolean(nullable: false),
                        FuelCap = c.Boolean(nullable: false),
                        DomeLight = c.Boolean(nullable: false),
                        CabinFilter = c.String(),
                        ParkingBrake = c.Boolean(nullable: false),
                        DriverFloormat = c.Boolean(nullable: false),
                        AirFilter = c.String(),
                        BatteryCondition = c.String(),
                        BatteryHealth = c.String(),
                        CoolingSystems = c.Boolean(nullable: false),
                        Hoses = c.Boolean(nullable: false),
                        DriveBelts = c.Boolean(nullable: false),
                        Radiator_Condensor = c.Boolean(nullable: false),
                        WinshieldWasher = c.Boolean(nullable: false),
                        Coolant = c.Boolean(nullable: false),
                        PowerSteering = c.Boolean(nullable: false),
                        Brake = c.Boolean(nullable: false),
                        Clutch = c.Boolean(nullable: false),
                        Transmission = c.Boolean(nullable: false),
                        Differential = c.Boolean(nullable: false),
                        TransferCase = c.Boolean(nullable: false),
                        CvShaft = c.String(),
                        AxleHubBearing = c.String(),
                        SteeringLink = c.String(),
                        Suspension = c.String(),
                        FluidLeaks = c.String(),
                        Exhaust = c.String(),
                        FuelLines = c.String(),
                        Driveshaft = c.String(),
                        LfWear = c.Boolean(nullable: false),
                        LfTread = c.Int(nullable: false),
                        RfWear = c.Boolean(nullable: false),
                        RfTread = c.Int(nullable: false),
                        LrWear = c.Boolean(nullable: false),
                        LrTread = c.Int(nullable: false),
                        RrWear = c.Boolean(nullable: false),
                        RrTread = c.Int(nullable: false),
                        FrontPsi = c.Int(nullable: false),
                        BackPsi = c.Int(nullable: false),
                        LfBrakes = c.Int(nullable: false),
                        LrBrakes = c.Int(nullable: false),
                        RfBrakes = c.Int(nullable: false),
                        RrBrakes = c.Int(nullable: false),
                        BrakeLining = c.String(),
                        BrakeAssbly = c.Boolean(nullable: false),
                        Discs_Calipers = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.InspectionRecords");
        }
    }
}
