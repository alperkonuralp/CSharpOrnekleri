using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Property_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaman z = new Zaman();
            z.Saat = 12;
            z[1] = 5;
            z["sn"] = 20;

            Console.WriteLine(z[20.0]);
        }
    }
}
