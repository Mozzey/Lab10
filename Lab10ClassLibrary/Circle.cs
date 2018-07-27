using System;

namespace Lab10ClassLibrary
{
    public class Circle
    {
        // properties
        private double Radius { get; set; }
        public double Pi { get; private set; }
        static int NumberOfCirclesCreated = 0;
        // constructor
        public Circle(double radius)
        {
            Radius = radius;                   
            Pi = Math.PI;
            NumberOfCirclesCreated++;
        } 
        // method to access the number of circles created
        public static int GetNumberOfCircles()
        {
            return NumberOfCirclesCreated;
        }
        // calculate circumference of a circle
        public double CalculateCircumference() 
        {
            return 2 * Pi * Radius;
        }
        // calculate the circumference of the formatted user input
        public string CalculateFormattedCircumference()
        {
            double formattedCircumference = double.Parse($"{CalculateCircumference()}");
            return FormatNumber(formattedCircumference);
        }
        // calculate area of a circle
        public double CalculateArea()
        {
          return Pi * (Radius * Radius);  
        }
        // calculate the area of the formatted user input
        public string CalculateFormattedArea()
        {
            double formattedArea = double.Parse($"{CalculateArea()}");
            return FormatNumber(formattedArea);
        }
        // formats calculations - rounds to the nearest 2 decimal places
        private string FormatNumber(double x)
        {
            return String.Format($"{Math.Round(x, 2)}");
        }
    }
}
