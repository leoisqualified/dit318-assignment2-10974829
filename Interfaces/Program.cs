using System;
using System.Runtime.ConstrainedExecution;

namespace Interfaces
{
    // Main class to run the program
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            // Call the Move method on each instance
            car.Move();      // Output: Car is moving
            bicycle.Move();  // Output: Bicycle is moving
        }
    }
}
