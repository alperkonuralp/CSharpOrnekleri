using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ParaBirimiInt pbi = new ParaBirimiInt();

            ParaBirimi<int> pbi2 = new ParaBirimi<int>();

            pbi2.Deger = 12;

            ParaBirimi<long> pbl2 = new ParaBirimi<long>();

        }
    }
}
