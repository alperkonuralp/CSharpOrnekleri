using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Constructors
{
    public class Ogrenci
    {
        public const int GECISNOTU = 60;

        public readonly int[] Notlar;
        public static readonly string format1 = "{0} : {1}";

        public int no;
        public string ad;
        public string soyad;
        public int vize;
        public int final;

        public int Ortalama()
        {
            return (vize * 4 + final * 6) / 10;
        }

        public string GectiKaldi()
        {
            if (Ortalama() >= GECISNOTU)
                return "Geçti";
            else
            {
                return "Kaldı";
            }
        }

        public override string ToString()
        {
            return string.Format(format1, no, ad);
        }

        public Ogrenci()
        {
            Notlar = new int[15];
        }

        //public Ogrenci(int no, string ad, string soyad)
        //{
        //    this.no = no;
        //    this.ad = ad;
        //    this.soyad = soyad;
        //}

        //public Ogrenci(int no, string ad, string soyad, int vize)
        //    : this(no, ad, soyad)
        //{
        //    this.vize = vize;
        //}

        //public Ogrenci(int no, string ad, string soyad,
        //    int vize, int final)
        //    : this(no, ad, soyad, vize)
        //{
        //    this.final = final;
        //}

        public Ogrenci(int no, string ad, string soyad,
            int vize, int final)
            : this()
        {
            this.no = no;
            this.ad = ad;
            this.soyad = soyad;
            this.vize = vize;
            this.final = final;
        }

        public Ogrenci(int no, string ad, string soyad,
            int vize)
            : this(no, ad, soyad, vize, 0)
        {

        }

        public Ogrenci(int no, string ad, string soyad)
            : this(no, ad, soyad, 0, 0)
        {

        }
    }
}
