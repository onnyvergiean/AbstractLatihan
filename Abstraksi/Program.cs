using Abstraksi.Interface;
using System;

//namespace Abstraksi.AbstractClass
namespace Abstraksi.Interface

{
    class Program
    {
        static void Main(string[] args)
        {

            /*Hewan hewan;  objek polymoprphsim bagian Abstract Class

            hewan = new Ikan();
            hewan.Bernafas();


            hewan = new Burung();
            hewan.Bernafas();


            hewan = new Serangga();
            hewan.Bernafas();
            */

            //Bagian Interface

            iHewan hewan;

            hewan = new Ikan();
            hewan.Bernafas();

            hewan = new Burung();
            hewan.Bernafas();

            hewan = new Serangga();
            hewan.Bernafas();


            Console.ReadKey();
        }
    }
}
