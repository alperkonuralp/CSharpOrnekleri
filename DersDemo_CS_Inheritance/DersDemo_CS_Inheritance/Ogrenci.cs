using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Inheritance
{
    public class Ogrenci
    {
        public int no;
        public string adsoyad;

        protected double sayi;

        private DateTime zaman;

        public Ogrenci()
        {
            zaman = DateTime.Now;
        }

        public virtual string OkulAdi() {
            return string.Empty;
        }
    }

    public class EgeOgrencisi : Ogrenci
    {
        public override string OkulAdi() {
            return "Ege Üniversitesi";
        }
        public string[] alinanDersler;
        public double[] donemOrtalamalari;

        protected Guid denemeProtected;

        private string stringProtected;

        public EgeOgrencisi()
            : base()
        {

        }

    }
}
