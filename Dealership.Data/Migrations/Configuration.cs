namespace Dealership.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Dealership.Data.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Dealership.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Dealership.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.InspectionRecords.AddOrUpdate(
                r => r.Id,
                new InspectionRecord
                {
                    Id = 1,
                    Vin = "2C3AE76K44H068542",
                    DateIn = DateTime.Now,
                    OwnerId = 42,
                    Horn = true,
                    Lights_Signals = false,
                    WindshieldWiper = true,
                    WindshieldGlass = true,
                    FuelCap = false,
                    DomeLight = true,
                    CabinFilter = "OK",
                    ParkingBrake = false,
                    DriverFloormat = true,
                    AirFilter = "Future Need",
                    BatteryCondition = "Replace",
                    BatteryHealth = "OK",
                    CoolingSystems = false,
                    Hoses = true,
                    DriveBelts = true,
                    Radiator_Condensor = false,
                    WinshieldWasher = true,
                    Coolant = true,
                    PowerSteering = true,
                    Brake = false,
                    Clutch = false,
                    Transmission = true,
                    Differential = true,
                    TransferCase = true,
                    CvShaft = "Replace",
                    AxleHubBearing = "OK",
                    SteeringLink = "Replace",
                    Suspension = "Future Need",
                    FluidLeaks = "OK",
                    Exhaust = "Replace",
                    FuelLines = "OK",
                    Driveshaft = "Future Need",
                    LfWear = true,
                    LfTread = 1,
                    RfWear = true,
                    RfTread = 2,
                    LrWear = false,
                    LrTread = 3,
                    RrWear = true,
                    RrTread = 4,
                    FrontPsi = 23,
                    BackPsi = 24,
                    LfBrakes = 7,
                    LrBrakes = 3,
                    RfBrakes = 6,
                    RrBrakes = 4,
                    BrakeLining = "OK",
                    BrakeAssbly = true,
                    Discs_Calipers = true
                }
            );
        }
    }
}
