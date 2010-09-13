using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_OOP1
{
    public class Ogrenci
    {
        public string adi;
        public int no;

        public int vize;
        public int final;

        public int Ortalama() {
            return (vize * 4 + final * 6) / 10;
        }

        public static int GecisNotu = 65;

        public string GectiKaldi() {
            if (Ortalama() >= GecisNotu)
            {
                return "Geçti";
            }
            return "Kaldı"; 
        }

    }
}
