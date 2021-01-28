using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeSimple
    {
        public void NullExceptionSimpleOk()
        {
            TestClass Tc;
            Tc = new TestClass();
            _ = Tc.GetHashCode();

        }

        public void NullExceptionSimpleBad()
        {
            TestClass Tc;
            Tc = null;
            _ = Tc.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}