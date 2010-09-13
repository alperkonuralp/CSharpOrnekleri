using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> sporcular = new LinkedList<string>();
            sporcular.AddLast("A");
            sporcular.AddLast("B");
            sporcular.AddLast("C");
            sporcular.AddLast("D");
            sporcular.AddLast("E");
            sporcular.AddLast("F");
            sporcular.AddLast("G");
            sporcular.AddLast("H");

            sporcular.Remove("H");
            sporcular.AddFirst("H");

            sporcular.Remove("E");
            sporcular.AddFirst("E");

            sporcular.AddAfter(sporcular.First, "X");

            LinkedListNode<string> c =
                sporcular.Find("C");

            sporcular.AddBefore(c, "Y");

            foreach (string item in sporcular)
            {
                Console.WriteLine(item);
            }

        }
    }
}
