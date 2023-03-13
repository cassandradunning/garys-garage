using System;

namespace Garage
{
    interface IGasVehicle
    {
        int CurrentTankPercentage { get; set; }

        void RefuelTank();

    }
}