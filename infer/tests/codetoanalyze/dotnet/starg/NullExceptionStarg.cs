using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeStarg
    {
        public void NullExceptionStarg1Ok()
        {
            TestClass FirstLocal;
            FirstLocal = TestClass.TestStarg(TestClass.ReturnNullOnFalse(true),TestClass.ReturnNullOnFalse(true));
            _ = FirstLocal.GetHashCode();


        }

        public void NullExceptionStarg2Ok()
        {
            TestClass FirstLocal;
            FirstLocal = TestClass.TestStarg(TestClass.ReturnNullOnFalse(true),TestClass.ReturnNullOnFalse(false));
            _ = FirstLocal.GetHashCode();

        }

        public void NullExceptionStarg3Ok()
        {
            TestClass FirstLocal;
            FirstLocal = TestClass.TestStarg(TestClass.ReturnNullOnFalse(false),TestClass.ReturnNullOnFalse(true));
            _ = FirstLocal.GetHashCode();


        }

        public void NullExceptionStargBad()
        {
            TestClass FirstLocal;
            FirstLocal = TestClass.TestStarg(TestClass.ReturnNullOnFalse(false),TestClass.ReturnNullOnFalse(false));
            _ = FirstLocal.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}