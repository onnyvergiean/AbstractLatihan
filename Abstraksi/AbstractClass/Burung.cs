using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraksi.AbstractClass
{
    public class Burung : Hewan 
    {
        public override void Bernafas()
        {
            Console.WriteLine("Burung terbang di langit");
            Console.WriteLine("Bernafas dengan paru paru dibantu dengan kantong udara");
            Console.WriteLine();
        }
    }
}
