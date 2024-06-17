using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Interfaces
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

