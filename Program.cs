using System;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.BatteryKWh = 56;
            fxs.ChargeBattery();

            Tesla telsa = new Tesla();
            telsa.BatteryKWh = 100;
            telsa.ChargeBattery();

            Cessna cessna = new Cessna();
            cessna.FuelCapacity = 100;
            cessna.RefuelTank();

            fxs.Drive();
            telsa.Drive();
            cessna.Drive();

        }
    }
}