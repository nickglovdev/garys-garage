using System;

namespace GarysGarage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Your Telsa is charge {this.BatteryKWh} KWh ");
        }

        public override void Drive()
        {
            Console.WriteLine($"The black telsa went zaaazoooM! ");
        }

    }
}