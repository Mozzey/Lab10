using System;
namespace Lab10ClassLibrary
{
    public class Validator
    {
        // validates user input for valid integer greater than 0
        public static double ValidateDouble()
        {
            Console.Write("Enter Radius: ");
            string userInput = Console.ReadLine();
            if (double.TryParse(userInput, out double validInt) && validInt > 0)
            {
                return validInt;
            }
            else
            {
                Console.WriteLine("Please enter a valid integer greater than 0");
                return ValidateDouble();
            }
        }
    }
}
