using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_GenericClass
{
    public enum ParaTuru { TL, USD, Euro, Pound };

    public class ParaBirimiInt
    {
        private int _deger;

        public int Deger
        {
            get { return _deger; }
            set { _deger = value; }
        }
        private ParaTuru _tur;

        public ParaTuru Tur
        {
            get { return _tur; }
            set { _tur = value; }
        }


    }

    public class ParaBirimiLong
    {
        private long _deger;

        public long Deger
        {
            get { return _deger; }
            set { _deger = value; }
        }
        private ParaTuru _tur;

        public ParaTuru Tur
        {
            get { return _tur; }
            set { _tur = value; }
        }


    }

    public class ParaBirimiDouble
    {
        private double _deger;

        public double Deger
        {
            get { return _deger; }
            set { _deger = value; }
        }
        private ParaTuru _tur;

        public ParaTuru Tur
        {
            get { return _tur; }
            set { _tur = value; }
        }


    }

    public class ParaBirimi<T>
    {
        private T _deger;

        public T Deger
        {
            get { return _deger; }
            set { _deger = value; }
        }
        private ParaTuru _tur;

        public ParaTuru Tur
        {
            get { return _tur; }
            set { _tur = value; }
        }

        public ParaBirimi()
        {

        }

        public ParaBirimi(T d, ParaTuru pt)
        {
            _deger = d;
            _tur = pt;
        }

    }
}
