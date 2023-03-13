using System;

namespace Garage
{
    interface IElectricVehicle
    {
        int CurrentChargePercentage { get; set; }

        void ChargeBattery();

    }
}