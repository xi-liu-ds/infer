using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeNumComparison
    {
        public void NullExceptionLessThanOk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 0;
            int SecondLocal;
            SecondLocal = 0;
            if (FirstLocal < SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionLessThanBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 0;
            int SecondLocal;
            SecondLocal = 1;
            if (FirstLocal < SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionUnsignedLessThanOk()
        {
            TestClass Tc;
            Tc = null;
            uint FirstLocal;
            FirstLocal = 0;
            uint SecondLocal;
            SecondLocal = 0;
            if (FirstLocal < SecondLocal)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionUnsignedLessThanBad()
        {
            TestClass Tc;
            Tc = null;
            uint FirstLocal;
            FirstLocal = 0;
            uint SecondLocal;
            SecondLocal = 1;
            if (FirstLocal < SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionLargerThanOk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 0;
            int SecondLocal;
            SecondLocal = 0;
            if (FirstLocal > SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionLargerThanBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 1;
            int SecondLocal;
            SecondLocal = 0;
            if (FirstLocal > SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionUnsignedLargerThanOk()
        {
            TestClass Tc;
            Tc = null;
            uint FirstLocal;
            FirstLocal = 0;
            uint SecondLocal;
            SecondLocal = 0;
            if (FirstLocal > SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionUnsignedLargerThanBad()
        {
            TestClass Tc;
            Tc = null;
            uint FirstLocal;
            FirstLocal = 1;
            uint SecondLocal;
            SecondLocal = 0;
            if (FirstLocal > SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionEqual1Ok()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 0;
            int SecondLocal;
            SecondLocal = 1;
            if (FirstLocal == SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionEqual2Ok()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 0;
            int SecondLocal;
            SecondLocal = -1;
            if (FirstLocal == SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionEqualBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 0;
            int SecondLocal;
            SecondLocal = 0;
            if (FirstLocal == SecondLocal)
                _ = Tc.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}