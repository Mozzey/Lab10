using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10ClassLibrary
{
    public class RunAgain
    {
        public static bool PlayAgain()
        {
            Console.WriteLine("Continue? (y/n)");
            string yOrNo = Console.ReadLine().ToLower();
            if (yOrNo.StartsWith("y"))
            {
                return true;
            }
            else if (yOrNo.StartsWith("n"))
            {
                Console.WriteLine($"Goodbye. You created {Circle.GetNumberOfCircles()} Circle object(s)");
                Console.ReadLine();
                return false;
            }
            else
            {
                return PlayAgain();
            }
        }
    }
}
