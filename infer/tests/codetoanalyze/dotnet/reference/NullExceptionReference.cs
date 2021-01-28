using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeReference
    {
        public void NullExceptionReferenceParameterOk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 0;
            int SecondLocal;
            SecondLocal = 0;
            TestClass.IncrementRefParameter(ref FirstLocal);
            if (FirstLocal == SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionReferenceParameterBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 0;
            int SecondLocal;
            SecondLocal = 1;
            TestClass.IncrementRefParameter(ref FirstLocal);
            if (FirstLocal == SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionReferenceStructOk()
        {
            TestClass FirstLocal;
            FirstLocal = TestClass.IncrementStructFieldViaAddress(0);
            _ = FirstLocal.GetHashCode();

        }

        public void NullExceptionReferenceStructBad()
        {
            TestClass FirstLocal;
            FirstLocal = TestClass.IncrementStructFieldViaAddress(1);
            _ = FirstLocal.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}