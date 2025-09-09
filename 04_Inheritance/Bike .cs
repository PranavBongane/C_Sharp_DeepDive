using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Inheritance
{
    public class Bike : Vehicle
    {
        public bool HasCarrier { get; set; }

        public Bike(string brand, int speed, bool hasCarrier)
            : base(brand, speed)
        {
            HasCarrier = hasCarrier;
        }

        public void DoWheelie()
        {
            Console.WriteLine($"{Brand} Bike is doing a wheelie! 🏍️");
        }
    }
}
