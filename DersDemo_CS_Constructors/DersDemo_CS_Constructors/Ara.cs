using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Constructors
{
    class Ara
    {
        private Ara()
        {

        }

        static Ara()
        {
            liste = new List<Ara>();
        }

        public static readonly List<Ara> liste;



        public static Ara Olustur()
        {
            Ara a = new Ara();
            liste.Add(a);
            return a;
        }
    }
}
