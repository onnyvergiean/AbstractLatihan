using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraksi.Interface
{
    public class Serangga : iHewan
    {
        public void Bernafas()
        {
            Console.WriteLine("Seranga Hidup di daratan");
            Console.WriteLine("Bernafas dengan trakea");
            Console.WriteLine();
        }
    }
}
