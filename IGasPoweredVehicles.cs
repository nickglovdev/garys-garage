using System;

namespace GarysGarage
{
    public interface IGasPoweredVehicle
    {
        int CurrentTankPercentage { get; set; }

        void RefuelTank();
    }

}