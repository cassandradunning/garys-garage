using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
    {

        public override void Drive()
        {
            // could also be this.MainColor
            Console.WriteLine($"The {MainColor} Ram drives recklessly.");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Ram turned too fast.");
        }

        public override void Stop()
        {
            Console.WriteLine(
                $"The {MainColor} Ram suddenly stops."
            );

            // public double FuelCapacity { get; set; }
            // public string MainColor { get; set; }
            // public int MaximumOccupancy { get; set; }

            // public void RefuelTank()
            // {
            // method definition omitted
            // }
        }
        public void RefuelTank()
        {
            this.CurrentTankPercentage = 100;
        }
        //  not redefining get/set, just makes it required
        public int CurrentTankPercentage { get; set; } = 25;

    }
}