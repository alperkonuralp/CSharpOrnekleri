using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DersDemo_CS_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["Ad"] = "Alper";
            ht.Add("Soyad", "Konuralp");
            ht.Add("Vize", 45);
            ht.Add("Final", 55);

            // tarih bazında satış
            Hashtable ht2 = new Hashtable();
            ht2[new DateTime(2010, 9, 5)] = 1250;
            ht2.Add(new DateTime(2010, 9, 6), 2500);


            SortedList sl = new SortedList();
            sl[new DateTime(2010, 9, 5)] = 1250;
            sl.Add(new DateTime(2010, 9, 6), 2500);
            sl.Add(new DateTime(2010, 9, 1), 750);

            
        }
    }
}
