using System;
namespace GarysGarage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"You have this much gas {this.FuelCapacity}% ");
        }
        public override void Drive()
        {
            Console.WriteLine($"The Blue Ram went Is that a heeeeeemeeeiiii! ");
        }
    }
}