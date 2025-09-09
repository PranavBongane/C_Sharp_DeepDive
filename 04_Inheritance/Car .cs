using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Inheritance
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, int speed, int doors)
            : base(brand, speed) // call Vehicle constructor
        {
            NumberOfDoors = doors;
        }

        public void OpenTrunk()
        {
            Console.WriteLine($"{Brand} Car trunk opened 🚗");
        }
    }
}
