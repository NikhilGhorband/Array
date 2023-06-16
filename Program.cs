using System;
namespace UC2_Inheritance
{
    internal class Vehicle
    {
        public void DisplayVehicle()
        {
            Console.WriteLine("LandRover");
        }
    }

   
    
    // singal Inheritance
    class Bike : Vehicle
    {
        public void DisplayBike()
        {
            Console.WriteLine("Discovery");
        }
    }
    // Multilevel Inheritance
    class Car2 : Car
    {
        public void DisplayCar2()
        {
            Console.WriteLine("Defender");
        }
    }
    
}






