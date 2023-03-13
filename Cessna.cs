using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle  // Propellor light aircraft
    {
        // public double FuelCapacity { get; set; }
        // // public string MainColor { get; set; }
        // // public int MaximumOccupancy { get; set; }

        // public void RefuelTank()
        // {
        //     // method definition omitted
        // }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna drives down the street");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Cessna turns right");
        }

        public override void Stop()
        {
            Console.WriteLine(
                $"The {MainColor} Cessna squeals to stop."
            );
        }

        public void RefuelTank()
        {
            this.CurrentTankPercentage = 100;
        }
        //  not redefining get/set, just makes it required
        public int CurrentTankPercentage { get; set; } = 10;
    }
}