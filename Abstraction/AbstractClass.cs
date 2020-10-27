using System;

namespace Abstraction
{
    abstract class AbstractClass
    {

        public AbstractClass()
        {
            Console.WriteLine("1  Abstract Class");
            this.Method();
            Console.WriteLine("2  Abstract Class");
        }

        public abstract void Method();
    }
}
