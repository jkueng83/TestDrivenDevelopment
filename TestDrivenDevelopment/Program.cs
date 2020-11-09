using System;
using System.Threading;
using TestDrivenDevelopment.Klassen;

namespace TestDrivenDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Test Driven Development!");

            Coffee coffee = new Coffee();

            while (!coffee.Temperature.Equals("Cold"))
            {

                Console.WriteLine("Termoeratur: " + coffee.Temperature);
            }
            Console.WriteLine("Termoeratur: " + coffee.Temperature);
            Breakfast breakfast = new Breakfast();



            Console.ReadLine();
        }
    }
}
