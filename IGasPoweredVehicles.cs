using System;

namespace GarysGarage
{
    public interface IGasPoweredVehicle
    {
        int CurrentGasPercentage { get; set; }

        void RefuelTank();
    }

}