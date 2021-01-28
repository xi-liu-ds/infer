using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeNullDerefInterproc
    {
        public void NullExceptionInterprocOk()
        {
            TestClass Tc;
            Tc = TestClass.ReturnNullOnFalse(true);
            _ = Tc.GetHashCode();

        }

        public void NullExceptionInterprocBad()
        {
            TestClass Tc;
            Tc = TestClass.ReturnNullOnFalse(false);
            _ = Tc.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}