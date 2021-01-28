using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeArray
    {
        public void NullExceptionArrayOneDim1Ok()
        {
            TestClass[] FirstLocal;
            FirstLocal = TestClass.ReturnOneDimArray(true,true);
            TestClass SecondLocal;
            SecondLocal = FirstLocal[0];
            _ = SecondLocal.GetHashCode();

        }

        public void NullExceptionArrayOneDim1Bad()
        {
            TestClass[] FirstLocal;
            FirstLocal = TestClass.ReturnOneDimArray(false,true);
            TestClass SecondLocal;
            SecondLocal = FirstLocal[0];
            _ = SecondLocal.GetHashCode();

        }

        public void NullExceptionArrayOneDim2Ok()
        {
            TestClass[] FirstLocal;
            FirstLocal = TestClass.ReturnOneDimArray(true,false);
            TestClass SecondLocal;
            SecondLocal = FirstLocal[0];
            _ = SecondLocal.GetHashCode();

        }

        public void NullExceptionArrayOneDim2Bad()
        {
            TestClass[] FirstLocal;
            FirstLocal = TestClass.ReturnOneDimArray(false,false);
            TestClass SecondLocal;
            SecondLocal = FirstLocal[0];
            _ = SecondLocal.GetHashCode();

        }

        public void NullExceptionArrayTwoDimOk()
        {
            TestClass[][] FirstLocal;
            FirstLocal = TestClass.ReturnTwoDimArray(true);
            TestClass[] SecondLocal;
            SecondLocal = FirstLocal[0];
            _ = SecondLocal.GetHashCode();

        }

        public void NullExceptionArrayTwoDimBad()
        {
            TestClass[][] FirstLocal;
            FirstLocal = TestClass.ReturnTwoDimArray(false);
            TestClass[] SecondLocal;
            SecondLocal = FirstLocal[0];
            _ = SecondLocal.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}