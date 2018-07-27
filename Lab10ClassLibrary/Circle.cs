using System;
using Lab10;
using Lab10ClassLibrary;
using System.Collections.Generic;

namespace Lab10ClassLibrary
{
    public class Circle
    {
        private double Radius { get; set; }
        public double Pi { get; private set; }
        static int NumberOfCirclesCreated = 0;
        
        public Circle(double radius)
        {
            Radius = radius;                   
            Pi = Math.PI;
            NumberOfCirclesCreated++;
        } 
        public static int GetNumberOfCircles()
        {
            return NumberOfCirclesCreated;
        }
        public double CalculateCircumference() 
        {
            return 2 * Pi * Radius;
        }
        public string CalculateFormattedCircumference()
        {
            double formattedCircumference = double.Parse($"{CalculateCircumference()}");
            return FormatNumber(formattedCircumference);
        }
        public double CalculateArea()
        {
          return Pi * (Radius * Radius);  
        }
        public string CalculateFormattedArea()
        {
            double formattedArea = double.Parse($"{CalculateArea()}");
            return FormatNumber(formattedArea);
        }
        private string FormatNumber(double x)
        {
            return String.Format($"{Math.Round(x, 2)}");
        }
    }
}
