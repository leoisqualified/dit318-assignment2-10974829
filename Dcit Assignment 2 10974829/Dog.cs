using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace InheritanceAndMethodOverriding
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}

