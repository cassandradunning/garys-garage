using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
    {
        // public double BatteryKWh { get; set; }
        // // public string MainColor { get; set; }
        // // public int MaximumOccupancy { get; set; }

        // public void ChargeBattery()
        // {
        //     // method definition omitted
        // }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drove past you.");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Zero turns into the parking lot");
        }

        public override void Stop()
        {
            Console.WriteLine(
                $"The {MainColor} Zero stopped at a red light."
            );
        }
        public void ChargeBattery()
        {
            this.CurrentChargePercentage = 100;
        }
        //  not redefining get/set, just makes it required
        public int CurrentChargePercentage { get; set; } = 50;

    }
}