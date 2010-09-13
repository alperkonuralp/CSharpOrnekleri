using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Abstract2
{
    public abstract class Siralama
    {
        public abstract bool Karsilastir(object a, object b);

        public void Sirala(Array dizi)
        {
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = 0; j < dizi.Length - i - 1; j++)
                {
                    object x = dizi.GetValue(j); // dizi[j]
                    object y = dizi.GetValue(j+1); // dizi[j+1]

                    if (Karsilastir(x, y))
                    {
                        object z = x;
                        x = y;
                        y = z;

                        dizi.SetValue(x, j); // dizi[j] = x;
                        dizi.SetValue(y, j+1); // dizi[j+1] = y;
                    }
                }
            }
        }
    }
}
