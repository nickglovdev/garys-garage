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
        public override void Drive()
        {
            Console.WriteLine($"The green zero went Kapoo! ");
        }
        public override void Turn()
        {
            Console.WriteLine("I'm turning 60 degrees south by west");
        }
        public override void stop()
        {
            Console.WriteLine("OH GOD STOP NOOOOO!!!!!");
        }
    }
}