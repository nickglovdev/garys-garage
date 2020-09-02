using System;

namespace GarysGarage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Your Zero is charge {this.BatteryKWh} KWh ");
        }
    }
}