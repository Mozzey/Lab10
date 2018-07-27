using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Validator
    {
        // validates
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
