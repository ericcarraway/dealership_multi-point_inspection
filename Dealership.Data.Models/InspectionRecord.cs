using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Data.Models
{
    public class InspectionRecord
    {
        public int Id { get; set; }
        [Required]
        public string Vin { get; set; }
        public DateTime DateIn { get; set; }

        // Foreign Keys
        public int OwnerId { get; set; }
        // TODO:
        // Foreign Keys for other tables per client spec

        // Exerior
        public bool Horn { get; set; }
        public bool Lights_Signals { get; set; }
        public bool WindshieldWiper { get; set; }
        public bool WindshieldGlass { get; set; }
        public bool FuelCap { get; set; }

        // Interior
        public bool DomeLight { get; set; }
        public string CabinFilter { get; set; } // OK, Future Need, Replace
        public bool ParkingBrake { get; set; }
        public bool DriverFloormat { get; set; }

        // Under Hood
        public string AirFilter { get; set; }        // OK, Future Need, Replace
        public string BatteryCondition { get; set; } // OK, Future Need, Replace
        public string BatteryHealth { get; set; }    // OK, Future Need, Replace
        public bool CoolingSystems { get; set; }
        public bool Hoses { get; set; }
        public bool DriveBelts { get; set; }
        public bool Radiator_Condensor { get; set; }

        // Fluids
        public bool WinshieldWasher { get; set; }
        public bool Coolant { get; set; }
        public bool PowerSteering { get; set; }
        public bool Brake { get; set; }
        public bool Clutch { get; set; }
        public bool Transmission { get; set; }
        public bool Differential { get; set; }
        public bool TransferCase { get; set; }

        // Under Vehicles
        public string CvShaft { get; set; }        // OK, Future Need, Replace
        public string AxleHubBearing { get; set; } // OK, Future Need, Replace
        public string SteeringLink { get; set; }   // OK, Future Need, Replace
        public string Suspension { get; set; }     // OK, Future Need, Replace
        public string FluidLeaks { get; set; }     // OK, Future Need, Replace
        public string Exhaust { get; set; }        // OK, Future Need, Replace
        public string FuelLines { get; set; }      // OK, Future Need, Replace
        public string Driveshaft { get; set; }     // OK, Future Need, Replace

        // Tires
        public bool LfWear { get; set; }
        public int LfTread { get; set; }
        public bool RfWear { get; set; }
        public int RfTread { get; set; }
        public bool LrWear { get; set; }
        public int LrTread { get; set; }
        public bool RrWear { get; set; }
        public int RrTread { get; set; }
        public int FrontPsi { get; set; }
        public int BackPsi { get; set; }

        // Brakes
        public int LfBrakes { get; set; }
        public int LrBrakes { get; set; }
        public int RfBrakes { get; set; }
        public int RrBrakes { get; set; }
        public string BrakeLining { get; set; } // OK, Future Need, Replace
        public bool BrakeAssbly { get; set; }
        public bool Discs_Calipers { get; set; }
    }
}
