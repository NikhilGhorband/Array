using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_Inheritance
{
    public class Inheritance
    {
        public string brand = "LandRover";
        public void Vehicle()
        {
            Console.WriteLine(" Revv");
        }
    }
    class Car : Inheritance
    {
        public string modelName = "Velar";
    }
}

