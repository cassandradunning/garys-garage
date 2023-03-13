using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle// Electric car
    {
        // public double BatteryKWh { get; set; }
        // // get rid of bc it's already in the parent 
        // // public string MainColor { get; set; }
        // // public int MaximumOccupancy { get; set; }

        // public void ChargeBattery()
        // {
        //     // method definition omitted
        // }
        // public override void Drive()
        // {
        //     Console.WriteLine($"{this.MainColor}");
        // }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla floats on by without a driver.");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Tesla turned too fast!");
        }

        public override void Stop()
        {
            Console.WriteLine(
                $"The {MainColor} Tesla stopped on auto-pilot."
            );
        }

        public void ChargeBattery()
        {
            this.CurrentChargePercentage = 100;
        }
        public int CurrentChargePercentage { get; set; } = 50;
    }
}