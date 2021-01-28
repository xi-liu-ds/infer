using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeNullParam
    {
        public void NullExceptionNullParamOk()
        {
            TestClass Tc;
            Tc = new TestClass();
            TestClass.ExpectNonNullParam(Tc);

        }

        public void NullExceptionNullParamBad()
        {
            TestClass Tc;
            Tc = null;
            TestClass.ExpectNonNullParam(Tc);

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}