using System;

namespace Lab10ClassLibrary
{
    public class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
            Pi = Math.PI;
        }
        
        public double CalculateCircumference()
        {
            return 2 * Pi * Radius;
        }
        
        /*
        public string CalculateFormattedCircumference()
        {

        }
        */
        public double CalculateArea()
        {
          return Pi * (Radius * Radius);  
        }
        /*
        public string CalculateFormattedArea()
        {

        }
        */
        private string FormatNumber(double x)
        {
            return $"{x:0.00}";
        }
        private double Radius { get; set; }
        public double Pi { get; private set; }
    }
}
