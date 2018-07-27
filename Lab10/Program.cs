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
                // greet the user
                Console.WriteLine("Welcome to the Circle Tester");
                // set valid integer input - check by Validator Class
                double userInput = Validator.ValidateDouble();
                // initialize a new circle
                var circle = new Circle(userInput);
                // display calculations
                Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
                // if user decides not to run the program again say goodbye and 
                // display the number of circle object(s) created
                if (!RunAgain.PlayAgain())
                {
                    isRunning = false;
                }
            }
        }
    }
}
