using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeLdstr
    {
        public void NullExceptionLdstrOk()
        {
            string FirstLocal;
            FirstLocal = "hello";
            _ = FirstLocal.GetHashCode();

        }

        public void NullExceptionLdstrBad()
        {
            string FirstLocal;
            FirstLocal = null;
            _ = FirstLocal.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}