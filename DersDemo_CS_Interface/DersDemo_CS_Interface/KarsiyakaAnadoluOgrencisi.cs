using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Interface
{
    public class KarsiyakaAnadoluOgrencisi : Ogrenci,
        ITurkce, IMatematik, IFen
    {
        private float turkceNeti, matematikNeti, fenNeti;

        /// <summary>
        /// Initializes a new instance of the <see cref="KarsiyakaAnadoluOgrencisi"/> class.
        /// </summary>
        /// <param name="tn">Türkçe Neti</param>
        /// <param name="mn">Matematik Neti</param>
        /// <param name="fn">Fen Neti</param>
        public KarsiyakaAnadoluOgrencisi(
            float tn, float mn, float fn
            )
        {
            turkceNeti = tn;
            matematikNeti = mn;
            fenNeti = fn;
        }

        #region ITurkce Members

        public float TurkceNeti()
        {
            return turkceNeti;
        }

        #endregion

        #region IMatematik Members

        public float MatematikNeti()
        {
            return matematikNeti;
        }

        #endregion

        #region IFen Members

        float IFen.FenNeti()
        {
            return fenNeti;
        }

        #endregion
    }
}
