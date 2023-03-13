using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {

            Console.WriteLine($"The {MainColor} vehicle moves past you. Vrooom!");
        }
        public virtual void Turn()
        {
            Console.WriteLine($"The {MainColor} vehicle carefully turns right.");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"The {MainColor} vehicle slowly rolls to a stop.");
        }

    }
}