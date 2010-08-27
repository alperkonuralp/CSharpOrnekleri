using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_CarpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1*1=1  2*1=2  3*1=3  4*1=4  5*1=5
            // 1*2=2  2*2=4  3*2=6  4*2=8  5*2=10
            // 1*3=3  2*3=6  3*3=9  4*3=12 5*3=15


            //1234567890
            //1234567890
            //1234567890
            //1234567890
            //1234567890
            //1234567890
            //1234567890
            //1234567890
            //1234567890
            //1234567890
            //1234567890

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    Console.Write("{0}*{1}={2,-2} ", j, i, j * i);
                }
                Console.WriteLine();
            }
        }
    }
}
