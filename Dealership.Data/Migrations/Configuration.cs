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
                r => r.Vin,
                new InspectionRecord
                {
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
                },
                 new InspectionRecord
                {
                    Vin = "WDBTJ56J06F449710",
                    DateIn = new DateTime(2014, 9, 15, 8, 22, 0),
                    OwnerId = 22,
                    Horn = true,
                    Lights_Signals = true,
                    WindshieldWiper = true,
                    WindshieldGlass = false,
                    FuelCap = true,
                    DomeLight = false,
                    CabinFilter = "Future Need",
                    ParkingBrake = true,
                    DriverFloormat = true,
                    AirFilter = "OK",
                    BatteryCondition = "Replace",
                    BatteryHealth = "OK",
                    CoolingSystems = true,
                    Hoses = true,
                    DriveBelts = true,
                    Radiator_Condensor = false,
                    WinshieldWasher = false,
                    Coolant = true,
                    PowerSteering = true,
                    Brake = true,
                    Clutch = false,
                    Transmission = true,
                    Differential = true,
                    TransferCase = true,
                    CvShaft = "OK",
                    AxleHubBearing = "OK",
                    SteeringLink = "Replace",
                    Suspension = "Replace",
                    FluidLeaks = "OK",
                    Exhaust = "OK",
                    FuelLines = "OK",
                    Driveshaft = "Future Need",
                    LfWear = true,
                    LfTread = 5,
                    RfWear = false,
                    RfTread = 4,
                    LrWear = false,
                    LrTread = 5,
                    RrWear = true,
                    RrTread = 4,
                    FrontPsi = 28,
                    BackPsi = 27,
                    LfBrakes = 8,
                    LrBrakes = 5,
                    RfBrakes = 6,
                    RrBrakes = 5,
                    BrakeLining = "OK",
                    BrakeAssbly = false,
                    Discs_Calipers = true
                },
                new InspectionRecord
                {
                    Vin = "3HGCG56432G255466",
                    DateIn = new DateTime(2014, 12, 23, 12, 54, 0),
                    OwnerId = 2,
                    Horn = true,
                    Lights_Signals = true,
                    WindshieldWiper = true,
                    WindshieldGlass = true,
                    FuelCap = true,
                    DomeLight = true,
                    CabinFilter = "Replace",
                    ParkingBrake = false,
                    DriverFloormat = true,
                    AirFilter = "Replace",
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
                    AxleHubBearing = "Repalce",
                    SteeringLink = "Replace",
                    Suspension = "Future Need",
                    FluidLeaks = "Future Need",
                    Exhaust = "Replace",
                    FuelLines = "Future Need",
                    Driveshaft = "Future Need",
                    LfWear = false,
                    LfTread = 1,
                    RfWear = false,
                    RfTread = 2,
                    LrWear = false,
                    LrTread = 3,
                    RrWear = false,
                    RrTread = 4,
                    FrontPsi = 24,
                    BackPsi = 25,
                    LfBrakes = 8,
                    LrBrakes = 5,
                    RfBrakes = 6,
                    RrBrakes = 8,
                    BrakeLining = "Future Need",
                    BrakeAssbly = false,
                    Discs_Calipers = true
                }
            );
        }
    }
}
