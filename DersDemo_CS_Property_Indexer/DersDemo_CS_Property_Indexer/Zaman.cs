using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Property_Indexer
{
    public class Zaman
    {
        private int _saat, _dakika, _saniye;

        public int Saat
        {
            get { return _saat; }
            set { _saat = value; }
        }

        public int Dakika
        {
            get { return _dakika; }
            set
            {
                if (value >= 60 && value < 0)
                {
                    throw new ArgumentException(
                        "Lütfen geçerli bir değer giriniz.",
                        "Dakika");
                }
                _dakika = value;
            }
        }

        public int Saniye
        {
            get { return _saniye; }
            set
            {
                if (value >= 60 && value < 0)
                {
                    throw new ArgumentException(
                        "Lütfen geçerli bir değer giriniz.",
                        "Saniye");
                }
                _saniye = value;
            }
        }

        public int Saniyeler
        {
            get
            {
                return _saat * 3600 + _dakika * 60 + _saniye;
            }
        }

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return _saat;
                    case 1:
                        return _dakika;
                    case 2:
                        return _saniye;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        Saat = value;
                        break;
                    case 1:
                        Dakika = value;
                        break;
                    case 2:
                        Saniye = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }



        public int this[string index]
        {
            get
            {
                switch (index.ToLower())
                {
                    case "sa":
                    case "saat":
                        return _saat;
                    case "da":
                    case "dakika":
                        return _dakika;
                    case "sn":
                    case "saniye":
                        return _saniye;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index.ToLower())
                {
                    case "sa":
                    case "saat":
                        Saat = value;
                        break;
                    case "da":
                    case "dakika":
                        Dakika = value;
                        break;
                    case "sn":
                    case "saniye":
                        Saniye = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }


        public double this[double d]
        {
            get
            {
                double toplam = 0.0;
                for (int i = 1; i <= d; i++)
                {
                    toplam += i;
                }
                return toplam;
            }
        }
    }
}
