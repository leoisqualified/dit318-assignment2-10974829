using System;

namespace InheritanceAndMethodOverriding
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }
}
