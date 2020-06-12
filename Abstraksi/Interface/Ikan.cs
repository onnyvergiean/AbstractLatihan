using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraksi.Interface
{
    public class Ikan : iHewan
    {
        public void Bernafas()
        {
            Console.WriteLine("Ikan hidup di air");
            Console.WriteLine("Bernafas menggunakan Insang");
            Console.WriteLine();
        }

    }
}
