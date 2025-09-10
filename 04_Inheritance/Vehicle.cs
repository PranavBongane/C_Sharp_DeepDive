using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Inheritance
{
    // Base class: Vehicle
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public virtual void Start()
        {
            Console.WriteLine($"{Brand} started at {Speed} km/h");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"{Brand} stopped.");
        }
    }
}
