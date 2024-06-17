using System;

namespace AbstractClassesAndMethods
{
    // Define the derived class Circle
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implement the GetArea method to calculate the area of a circle
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
