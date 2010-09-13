using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Interface
{
    public class TrabzonLisesiOgrencisi : Ogrenci, 
        IMatematik, ITurkce
    {
        public float matematikNeti, turkceNeti;

        #region IMatematik Members

        public float MatematikNeti()
        {
            return matematikNeti;
        }

        #endregion

        #region ITurkce Members

        public float TurkceNeti()
        {
            return turkceNeti;
        }

        #endregion
    }
}
