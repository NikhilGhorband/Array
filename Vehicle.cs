using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_PolymorphismOverloading
{
    public class Vehicle
    {
        public string brand = "Jaguar";
        public void horn()
        {
            Console.WriteLine("Pomp Pomp");
        }
    }
    class Car : Vehicle
    {
        public string color = "White";
    }
}
