using System;
using Lab10ClassLibrary;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome to the Circle Tester");
                double validInput = Validator.ValidateDouble();
                var circle = new Circle(validInput);

                Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
                if (!RunAgain.PlayAgain())
                {
                    isRunning = false;
                }
            }
        }
    }
}
