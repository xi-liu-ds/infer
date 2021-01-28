using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeLogical
    {
        public void NullExceptionOR1Bad()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = true;
            bool SecondLocal;
            SecondLocal = true;
            if (FirstLocal || SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionOR2Bad()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = true;
            bool SecondLocal;
            SecondLocal = false;
            if (FirstLocal || SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionOR3Bad()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = false;
            bool SecondLocal;
            SecondLocal = true;
            if (FirstLocal || SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionOROk()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = false;
            bool SecondLocal;
            SecondLocal = false;
            if (FirstLocal || SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionANDBad()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = true;
            bool SecondLocal;
            SecondLocal = true;
            if (FirstLocal && SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionAND1Ok()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = true;
            bool SecondLocal;
            SecondLocal = false;
            if (FirstLocal && SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionAND2Ok()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = false;
            bool SecondLocal;
            SecondLocal = true;
            if (FirstLocal && SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionAND3Ok()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = false;
            bool SecondLocal;
            SecondLocal = false;
            if (FirstLocal && SecondLocal)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionXOR1Ok()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = true;
            bool SecondLocal;
            SecondLocal = true;
            if (FirstLocal ^ SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionXOR1Bad()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = true;
            bool SecondLocal;
            SecondLocal = false;
            if (FirstLocal ^ SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionXOR2Bad()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = false;
            bool SecondLocal;
            SecondLocal = true;
            if (FirstLocal ^ SecondLocal)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionXOR2Ok()
        {
            TestClass Tc;
            Tc = null;
            bool FirstLocal;
            FirstLocal = false;
            bool SecondLocal;
            SecondLocal = false;
            if (FirstLocal ^ SecondLocal)
                _ = Tc.GetHashCode();
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}