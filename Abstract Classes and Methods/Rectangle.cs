using System;

namespace AbstractClassesAndMethods
{
    // Define the derived class Rectangle
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Implement the GetArea method to calculate the area of a rectangle
        public override double GetArea()
        {
            return width * height;
        }
    }
}
