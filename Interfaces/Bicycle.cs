using System;

namespace InterfacesExample
{
    // Create the class Bicycle that implements IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}
