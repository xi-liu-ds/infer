using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeBgeBle
    {
        public void NullExceptionBge1Ok()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 1;
            int SecondLocal;
            SecondLocal = 0;
            if (FirstLocal < 0 && SecondLocal == 0)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionBge2Ok()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 0;
            int SecondLocal;
            SecondLocal = 0;
            if (FirstLocal < 0 && SecondLocal == 0)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionBgeBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = -1;
            int SecondLocal;
            SecondLocal = 0;
            if (FirstLocal < 0 && SecondLocal == 0)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionBle1Ok()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = -1;
            int SecondLocal;
            SecondLocal = 0;
            if (FirstLocal > 0 && SecondLocal == 0)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionBle2Ok()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 0;
            int SecondLocal;
            SecondLocal = 0;
            if (FirstLocal > 0 && SecondLocal == 0)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionBleBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 1;
            int SecondLocal;
            SecondLocal = 0;
            if (FirstLocal > 0 && SecondLocal == 0)
                _ = Tc.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}