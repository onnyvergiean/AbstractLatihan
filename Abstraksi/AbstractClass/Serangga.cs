using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraksi.AbstractClass
{
    public class Serangga : Hewan
    {
        public override void Bernafas()
        {
            Console.WriteLine("Seranga Hidup di daratan");
            Console.WriteLine("Bernafas dengan trakea");
            Console.WriteLine();
        }
    }
}
