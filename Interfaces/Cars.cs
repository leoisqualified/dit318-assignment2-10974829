using System;

namespace InterfacesExample
{
    // Create the class Car that implements IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}
