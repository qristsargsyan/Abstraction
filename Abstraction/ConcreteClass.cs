using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class ConcreteClass : AbstractClass
    {
        string name = "FIRST";

        public ConcreteClass()
        {
            Console.WriteLine("3  Concrete Class");
            name = "SECOND";
        }

        public override void Method()
        {
            Console.WriteLine("Implementation method Abstract Method in Concrete Class{0}  ",name);
        }
    }
}
