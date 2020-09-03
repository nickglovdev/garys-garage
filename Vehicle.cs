using System;

namespace GarysGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("VROOOM!");
        }
        public virtual void Turn()
        {
            Console.WriteLine("Wrong way! BAMM!W");
        }
        public virtual void stop()
        {
            Console.WriteLine("Silently the thing stopped moving before they shed a tear");
        }

    }
}