using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Delegate2
{
    public delegate void EkIslem();

    public class HesapMakinasi
    {
        public double ilkSayi;
        public double ikinciSayi;
        public double sonuc;

        public void Topla()
        {
            sonuc = ilkSayi + ikinciSayi;
        }
        public void Cikart()
        {
            sonuc = ilkSayi - ikinciSayi;
        }
        public void Carp()
        {
            sonuc = ilkSayi * ikinciSayi;
        }
        public void Bol()
        {
            sonuc = ilkSayi / ikinciSayi;
        }

        public EkIslem IlaveIslem;

        public void IlaveIslemiYap()
        {
            if (IlaveIslem != null)
            {
                IlaveIslem();
            }
        }
    }
}
