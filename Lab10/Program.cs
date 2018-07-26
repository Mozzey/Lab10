using System;
using Lab10ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            Console.Write("Enter Raidus: ");
            double radius = double.Parse(Console.ReadLine());
            var circle = new Circle(radius);

            Console.WriteLine(circle); // for testing erase later

            Console.ReadKey();
        }
    }
}
