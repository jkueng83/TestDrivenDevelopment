using System;
using System.Threading;
using TestDrivenDevelopment.Klassen;

namespace TestDrivenDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Coffee coffee = new Coffee();

             Console.WriteLine( "Termoeratur: " +  coffee.Temperature);

            Breakfast breakfast = new Breakfast();

           

            Console.ReadLine();
        }
    }
}
