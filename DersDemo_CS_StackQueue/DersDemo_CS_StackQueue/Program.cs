using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DersDemo_CS_StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            st.Push(6);

            while (st.Count > 0)
            {
                Console.WriteLine(st.Pop());
            }

            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
            Console.Clear();
            BitArray ba = new BitArray(new int[] { 1578947365 });
            StringBuilder sb = new StringBuilder();
            foreach (bool item in ba)
            {
                sb.Insert(0, item ? 1 : 0);
            }
            Console.WriteLine(sb.ToString());
            
            Console.WriteLine("{0:X}", 1578947365);
        }
    }
}
