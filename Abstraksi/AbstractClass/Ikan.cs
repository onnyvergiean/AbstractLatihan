using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraksi.AbstractClass
{
    public class Ikan : Hewan
    {
        public override void Bernafas()
        {
            Console.WriteLine("Ikan hidup di air");
            Console.WriteLine("Bernafas menggunakan Insang");
            Console.WriteLine();
        }
    }
}
