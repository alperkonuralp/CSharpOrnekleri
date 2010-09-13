using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opr
{
    public class Zaman
    {

        public int Saat, Dakika, Saniye;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zaman"/> class.
        /// </summary>
        public Zaman()
            : this(0, 0, 0) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zaman"/> class.
        /// </summary>
        /// <param name="saat">The saat.</param>
        /// <param name="dakika">The dakika.</param>
        /// <param name="saniye">The saniye.</param>
        public Zaman(int saat, int dakika, int saniye)
        {
            this.Saat = saat;
            this.Dakika = dakika;
            this.Saniye = saniye;
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}",
                Saat, Dakika, Saniye);
        }


        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.</param>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if (obj is Zaman)
            {
                return SaniyeOlarakAl() ==
                    ((Zaman)obj).SaniyeOlarakAl();
            }

            return false;
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        public override int GetHashCode()
        {
            return SaniyeOlarakAl();
        }



        /// <summary>
        /// Saniye olarak al.
        /// </summary>
        /// <returns></returns>
        public int SaniyeOlarakAl()
        {
            return Saat * 3600 + Dakika * 60 + Saniye;
        }

        /*Operatörler*/
        /// <summary>
        /// Implements the operator +.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static Zaman operator +(Zaman a, Zaman b)
        {
            Zaman c = new Zaman(
                a.Saat + b.Saat,
                a.Dakika + b.Dakika,
                a.Saniye + b.Saniye);
            if (c.Saniye >= 60)
            {
                c.Saniye %= 60;
                c.Dakika++;
            }

            if (c.Dakika >= 60)
            {
                c.Dakika %= 60;
                c.Saat++;
            }
            return c;
        }

        public static Zaman operator +(Zaman a, int saniye)
        {
            //Zaman c = new Zaman(
            //    a.Saat,
            //    a.Dakika,
            //    a.Saniye + saniye);
            //if (c.Saniye >= 60)
            //{
            //    c.Dakika += (c.Saniye - c.Saniye % 60) / 60;
            //    c.Saniye %= 60;
            //}

            //if (c.Dakika >= 60)
            //{
            //    c.Saat += (c.Dakika - c.Dakika % 60) / 60;
            //    c.Dakika %= 60;
            //}
            //return c;

            Zaman c = (Zaman)saniye;
            return a + c;
        }

        /// <summary>
        /// Implements the operator -.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static Zaman operator -(Zaman a, Zaman b)
        {
            Zaman c = new Zaman(
                a.Saat - b.Saat,
                a.Dakika - b.Dakika,
                a.Saniye - b.Saniye);
            if (c.Saniye < 0)
            {
                c.Saniye += 60;
                c.Dakika--;
            }

            if (c.Dakika < 0)
            {
                c.Dakika += 60;
                c.Saat--;
            }
            return c;
        }


        /// <summary>
        /// Implements the operator &gt;.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(Zaman a, Zaman b)
        {
            //int aa = a.Saat * 60 * 60 +
            //    a.Dakika * 60 + a.Saniye;
            //int bb = b.Saat * 60 * 60 +
            //    b.Dakika * 60 + b.Saniye;

            //return aa > bb;
            return a.SaniyeOlarakAl() > b.SaniyeOlarakAl();
        }

        /// <summary>
        /// Implements the operator &lt;.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(Zaman a, Zaman b)
        {
            //int aa = a.Saat * 60 * 60 +
            //    a.Dakika * 60 + a.Saniye;
            //int bb = b.Saat * 60 * 60 +
            //    b.Dakika * 60 + b.Saniye;

            //return aa < bb;
            return a.SaniyeOlarakAl() > b.SaniyeOlarakAl();
        }


        /// <summary>
        /// Implements the operator &gt;=.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(Zaman a, Zaman b)
        {
            return a.SaniyeOlarakAl() >= b.SaniyeOlarakAl();
        }

        /// <summary>
        /// Implements the operator &lt;=.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(Zaman a, Zaman b)
        {
            return a.SaniyeOlarakAl() >= b.SaniyeOlarakAl();
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(Zaman a, Zaman b)
        {
            return a.SaniyeOlarakAl() == b.SaniyeOlarakAl();
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(Zaman a, Zaman b)
        {
            return a.SaniyeOlarakAl() != b.SaniyeOlarakAl();
        }


        /// <summary>
        /// Performs an implicit conversion from <see cref="Opr.Zaman"/> to <see cref="System.Int32"/>.
        /// </summary>
        /// <param name="a">A.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator int(Zaman a)
        {
            return a.SaniyeOlarakAl();
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="System.Int32"/> to <see cref="Opr.Zaman"/>.
        /// </summary>
        /// <param name="a">A.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Zaman(int a)
        {
            Zaman b = new Zaman();

            b.Saniye = a % 60;
            b.Dakika = (a - b.Saniye) / 60 % 60;
            b.Saat = (a - b.Saniye - b.Dakika * 60) / 3600;

            return b;
        }
    }
}
