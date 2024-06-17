using System;

namespace AbstractClassesAndMethods
{
    // Main class to run the program
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            // Display their areas
            Console.WriteLine("Area of Circle: " + circle.GetArea());       // Output: Area of Circle: 78.53981633974483
            Console.WriteLine("Area of Rectangle: " + rectangle.GetArea()); // Output: Area of Rectangle: 24
        }
    }
}
