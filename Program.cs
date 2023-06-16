using System;

namespace UC4_Abstraction
{
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void Eat()
        {
            Console.WriteLine("Animal eats ");
        }
    }

    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog Barks ");

        }

        class Program
        {
            static void Main(string[] args)
            {
                Dog dog = new Dog();
                dog.AnimalSound();
                dog.Eat();


                Console.ReadLine();
            }
        }
    }
}

