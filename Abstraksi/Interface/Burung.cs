using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraksi.Interface
{
    public class Burung : iHewan
    {
        public void Bernafas() 
        {
            Console.WriteLine("Burung terbang di langit");
            Console.WriteLine("Bernafas dengan paru paru dibantu dengan kantong udara");
            Console.WriteLine();
        }

    }
}
