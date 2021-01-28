using System;
using System.IO;
namespace Cilsil.Test.Assets
{
    public class TestCodeResourceLeak
    {
        public void ResourceLeakInitInterprocOk()
        {
            TestClass.CloseStream(TestClass.ReturnInitializedStreamReader());

        }

        public void ResourceLeakInitInterprocBad()
        {
            TestClass.ReturnInitializedStreamReader();

        }

        public void ResourceLeakInterprocOk()
        {
            TestClass Tc;
            Tc = new TestClass();
            StreamReader FirstLocal;
            FirstLocal = TestClass.ReturnInitializedStreamReader();
            TestClass.CloseStream(FirstLocal);

        }

        public void ResourceLeakInterprocBad()
        {
            TestClass Tc;
            Tc = new TestClass();
            StreamReader FirstLocal;
            FirstLocal = TestClass.ReturnInitializedStreamReader();

        }

        public void ResourceLeakIntraprocCloseOk()
        {
            TestClass Tc;
            Tc = new TestClass();
            StreamReader FirstLocal;
            FirstLocal = TestClass.ReturnInitializedStreamReader();
            FirstLocal.Close();

        }

        public void ResourceLeakIntraprocCloseBad()
        {
            TestClass Tc;
            Tc = new TestClass();
            StreamReader FirstLocal;
            FirstLocal = TestClass.ReturnInitializedStreamReader();

        }

        public void ResourceLeakIntraprocDisposeOk()
        {
            TestClass Tc;
            Tc = new TestClass();
            MemoryStream FirstLocal;
            FirstLocal = TestClass.ReturnInitializedMemoryStream();
            FirstLocal.Dispose();

        }

        public void ResourceLeakIntraprocDisposeBad()
        {
            TestClass Tc;
            Tc = new TestClass();
            MemoryStream FirstLocal;
            FirstLocal = TestClass.ReturnInitializedMemoryStream();

        }

        public MemoryStream ResourceLeakReturnedResourceOk()
        {
            TestClass Tc;
            Tc = new TestClass();
            MemoryStream FirstLocal;
            FirstLocal = TestClass.ReturnInitializedMemoryStream();
            return FirstLocal;

        }

        public void ResourceLeakReturnedResourceBad()
        {
            TestClass Tc;
            Tc = new TestClass();
            MemoryStream FirstLocal;
            FirstLocal = TestClass.ReturnInitializedMemoryStream();

        }

        public void ResourceLeakStaticSingletonOk()
        {
            TestClass Tc;
            Tc = new TestClass();

        }

        public void ResourceLeakStaticSingletonBad()
        {
            TestClass Tc;
            Tc = new TestClass();
            Tc.InitializeStreamReaderObjectField();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}