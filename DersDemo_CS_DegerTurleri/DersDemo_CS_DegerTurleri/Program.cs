using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_DegerTurleri
{
    public enum Cinsiyet { Erkek, Kadın };
    public enum DovizKuru { TL, USD, Euro, Pound, Yen };
    class Program
    {

        static void Main(string[] args)
        {

            bool cinsiyet1 = true;

            string ogrenciAdi = "Alper";
            Cinsiyet ogrenciCinsiyeti = Cinsiyet.Erkek;

            Console.WriteLine(ogrenciCinsiyeti);

            //Cinsiyet c2 = Cinsiyet.Hadım;

            double para = 15.24;
            DovizKuru dovizKuru = DovizKuru.TL;

            ParaBirimi p;
            p.Deger = 15.24;
            p.Kur = DovizKuru.TL;

            ParaBirimi p2;
            p2.Deger = 67;
            p2.Kur = DovizKuru.Euro;

            Ogrenci o1;
            o1.No = 1;
            o1.Ad = "Alper";
            o1.Soyad = "Konuralp";
            o1.Vize = 55;
            o1.Final = 65;
            Console.WriteLine(o1);
            Console.WriteLine(o1.Ortalama());
        }
    }

    public struct ParaBirimi
    {
        public double Deger;
        public DovizKuru Kur;
    }

    public struct Ogrenci
    {
        public int No;
        public string Ad;
        public string Soyad;
        public byte Vize;
        public byte Final;

        public byte Ortalama()
        {
            return (byte)(((int)Vize * 4 + (int)Final * 6) / 10);
        }
    }
}
