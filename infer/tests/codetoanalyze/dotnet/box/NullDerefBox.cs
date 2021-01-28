using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeBox
    {
        public void NullExceptionBoxIntegersOk()
        {
            int FirstLocal;
            FirstLocal = 0;
            TestClass SecondLocal;
            SecondLocal = TestClass.TestBox(0);
            _ = SecondLocal.GetHashCode();

        }

        public void NullExceptionBoxIntegersBad()
        {
            int FirstLocal;
            FirstLocal = 1;
            TestClass SecondLocal;
            SecondLocal = TestClass.TestBox(1);
            _ = SecondLocal.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}