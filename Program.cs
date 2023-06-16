namespace UC3_PolymorphismOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOPS Concepts Problem");
            Console.WriteLine("Choose From Below Options ");
            Console.WriteLine("1.Class and Objects \n2.Vehicle \n3.Polymorphism - Method OverLoading\n4. Exit ");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Class & Objects");
                    ClassAndObjects objects = new ClassAndObjects();
                    objects.CreateClassAndObject();
                    break;
                case 2:
                    Console.WriteLine("Inheritance.(Vehicle)");
                    Car car = new Car();
                    car.horn();
                    Console.WriteLine("Color: " + car.color + " \nBrand: " + car.brand);
                    break;
                case 3:
                    Console.WriteLine("Polymorphism - Method Overloding");
                    Console.WriteLine("Addition :" + OverLoadingPolymorphism.add(4, 8));
                    break;

            }
        }
    }
}