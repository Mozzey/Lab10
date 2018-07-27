using System;
using System.Collections.Generic;
using Lab10ClassLibrary;

namespace Lab10ClassLibrary
{
    // asks the user if they would like to run the program again
    public class RunAgain
    {
        public static bool PlayAgain(List<Circle> listOfCircles)
        {
            Console.WriteLine("Continue? (y/n)");
            string yOrNo = Console.ReadLine().ToLower();
            if (yOrNo.StartsWith("y"))
            {
                return true;
            }
            else if (yOrNo.StartsWith("n"))
            {
                Console.WriteLine($"Goodbye. You created {listOfCircles.Count} Circle object(s)");
                Console.ReadLine();
                return false;
            }
            else
            {
                return PlayAgain(listOfCircles);
            }
        }
    }
}
