using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_IEqutable
{
    class Program : ICloneable
    {
        public static int DizideAra<T>(
            T[] dizi, T aranacak)
            where T : IEquatable<T>
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i].Equals(aranacak))
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] dizi1 = { 15, 58, 79, 47, 45, 1 };

            Console.WriteLine(DizideAra(dizi1, 47));
            Console.WriteLine(DizideAra(dizi1, 48));

            string[] dizi2 = { "a", "b", "c", "d", "e" };

            Console.WriteLine(DizideAra(dizi2, "c"));
            Console.WriteLine(DizideAra(dizi2, "ç"));


        }


        public int deneme1;
        public string deneme2;
        #region ICloneable Members

        public object Clone()
        {
            Program p = new Program();
            p.deneme1 = this.deneme1;
            p.deneme2 = this.deneme2;
            return p;
        }

        #endregion
    }
}
