using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeArithmetic
    {
        public void NullExceptionPlusOk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 5;
            int SecondLocal;
            SecondLocal = 7;
            if ((FirstLocal + SecondLocal) !=
                    12)_ = Tc.GetHashCode();

        }

        public void NullExceptionPlusBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 5;
            int SecondLocal;
            SecondLocal = 7;
            if ((FirstLocal + SecondLocal) ==
                    12)_ = Tc.GetHashCode();

        }

        public void NullExceptionMinusOk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 5;
            int SecondLocal;
            SecondLocal = 7;
            if ((FirstLocal - SecondLocal) != -2)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionMinusBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 5;
            int SecondLocal;
            SecondLocal = 7;
            if ((FirstLocal - SecondLocal) == -2)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionMultOk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 5;
            int SecondLocal;
            SecondLocal = 7;
            if ((FirstLocal * SecondLocal) != 35)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionMultBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 5;
            int SecondLocal;
            SecondLocal = 7;
            if ((FirstLocal * SecondLocal) == 35)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionDivOk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 5;
            int SecondLocal;
            SecondLocal = 7;
            if ((FirstLocal / SecondLocal) != 0)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionDivBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 5;
            int SecondLocal;
            SecondLocal = 7;
            if ((FirstLocal / SecondLocal) == 0)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionModOk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 5;
            int SecondLocal;
            SecondLocal = 7;
            if ((FirstLocal % SecondLocal) != 5)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionModBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 5;
            int SecondLocal;
            SecondLocal = 7;
            if ((FirstLocal % SecondLocal) == 5)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionUnsignedDivOk()
        {
            TestClass Tc;
            Tc = null;
            uint FirstLocal;
            FirstLocal = 14;
            uint SecondLocal;
            SecondLocal = 5;
            if ((FirstLocal / SecondLocal) != 2)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionUnsignedDivBad()
        {
            TestClass Tc;
            Tc = null;
            uint FirstLocal;
            FirstLocal = 14;
            uint SecondLocal;
            SecondLocal = 5;
            if ((FirstLocal / SecondLocal) == 2)
                _ = Tc.GetHashCode();

        }
        public void NullExceptionUnsignedModOk()
        {
            TestClass Tc;
            Tc = null;
            uint FirstLocal;
            FirstLocal = 14;
            uint SecondLocal;
            SecondLocal = 5;
            if ((FirstLocal % SecondLocal) != 4)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionUnsignedModBad()
        {
            TestClass Tc;
            Tc = null;
            uint FirstLocal;
            FirstLocal = 14;
            uint SecondLocal;
            SecondLocal = 5;
            if ((FirstLocal % SecondLocal) == 4)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionANDOk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 12;
            int SecondLocal;
            SecondLocal = 10;
            if ((FirstLocal & SecondLocal) != 8)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionANDBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 12;
            int SecondLocal;
            SecondLocal = 10;
            if ((FirstLocal & SecondLocal) == 8)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionOROk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 12;
            int SecondLocal;
            SecondLocal = 10;
            if ((FirstLocal | SecondLocal) != 14)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionORBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 12;
            int SecondLocal;
            SecondLocal = 10;
            if ((FirstLocal | SecondLocal) == 14)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionXOROk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 12;
            int SecondLocal;
            SecondLocal = 10;
            if ((FirstLocal ^ SecondLocal) != 6)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionXORBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 12;
            int SecondLocal;
            SecondLocal = 10;
            if ((FirstLocal ^ SecondLocal) == 6)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionLeftShiftOk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 10;
            int SecondLocal;
            SecondLocal = 1;
            if ((FirstLocal << SecondLocal) != 20)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionLeftShftBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 10;
            int SecondLocal;
            SecondLocal = 1;
            if ((FirstLocal << SecondLocal) == 20)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionRightShiftOk()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 10;
            int SecondLocal;
            SecondLocal = 1;
            if ((FirstLocal >> SecondLocal) != 5)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionRightShftBad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 10;
            int SecondLocal;
            SecondLocal = 1;
            if ((FirstLocal >> SecondLocal) == 5)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionBitwiseComp1Ok()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 12;
            if (~ FirstLocal != -13)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionBitwiseComp1Bad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 12;
            if (~ FirstLocal == -13)
                _ = Tc.GetHashCode();

        }

        public void NullExceptionBitwiseComp2Ok()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 12;
            if (- FirstLocal != -12)
                _ = Tc.GetHashCode();
        }

        public void NullExceptionBitwiseComp2Bad()
        {
            TestClass Tc;
            Tc = null;
            int FirstLocal;
            FirstLocal = 12;
            if (~ FirstLocal == -12)
                _ = Tc.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}