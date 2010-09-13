using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Indexer
{
    public partial class Dizim
    {
        private int _altLimit, _ustLimit;


        public int AltLimit
        {
            get { return _altLimit; }
        }

        public int UstLimit
        {
            get { return _ustLimit; }
        }


        private int[] _dizi;

        public Dizim(int altLimit, int ustLimit)
        {
            _altLimit = altLimit;
            _ustLimit = ustLimit;

            if (_altLimit > _ustLimit)
            {
                int ara = _altLimit;
                _altLimit = _ustLimit;
                _ustLimit = ara;
            }

            _dizi = new int[ElemanSayisi];
        }

        public int ElemanSayisi
        {
            get
            {
                return _ustLimit - _altLimit + 1;
            }
        }

        public int this[int index]
        {
            get
            {
                IndeksKontrol(index);
                return _dizi[index - _altLimit];
            }
            set
            {
                IndeksKontrol(index);
                _dizi[index - _altLimit] = value;
            }
        }

        private void IndeksKontrol(int index)
        {
            if (index < _altLimit || index > _ustLimit)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
