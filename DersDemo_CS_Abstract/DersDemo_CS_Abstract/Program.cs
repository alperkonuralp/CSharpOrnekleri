using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Abstract
{
    public interface IThird
    {
        void Method();
    }

    public abstract class Third : IThird
    {


        //public void Method()
        //{
        //    throw new NotImplementedException();
        //}

        public abstract void Method();

    }

    public class ThirdChild : Third
    {
        public override void Method()
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
