using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeIsInst
    {
        public void NullExceptionIsInst1Bad()
        {
            TestClass FirstLocal;
            FirstLocal = TestClass.TestIsInst(new TestClass());
            _ = FirstLocal.GetHashCode();

        }

        public void NullExceptionIsInst2Bad()
        {
            TestClass FirstLocal;
            FirstLocal = TestClass.TestIsInst(new object());
            _ = FirstLocal.GetHashCode();

        }

        public void NullExceptionIsInstOk()
        {
            TestClass FirstLocal;
            FirstLocal = TestClass.TestIsInst(null);
            _ = FirstLocal.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}