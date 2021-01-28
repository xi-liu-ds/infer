using System;
namespace Cilsil.Test.Assets
{
    public class TestCodeFieldDeref
    {
        public void NullExceptionFieldDeref1Ok()
        {
            TestClass Tc;
            Tc = new TestClass();
            Tc.InitializeInstanceObjectField(false);
            _ = Tc.InstanceObjectField.GetHashCode();

        }

        public void NullExceptionFieldDeref1Bad()
        {
            TestClass Tc;
            Tc = new TestClass();
            Tc.InitializeInstanceObjectField(true);
            _ = Tc.InstanceObjectField.GetHashCode();

        }

        public void NullExceptionFieldDeref2Ok()
        {
            TestClass Tc;
            Tc = new TestClass();
            Tc.InitializeInstanceObjectFieldViaReference(false);
            _ = Tc.InstanceObjectField.GetHashCode();

        }

        public void NullExceptionFieldDeref2Bad()
        {
            TestClass Tc;
            Tc = new TestClass();
            Tc.InitializeInstanceObjectFieldViaReference(true);
            _ = Tc.InstanceObjectField.GetHashCode();

        }

        public void NullExceptionStaticDeref1Ok()
        {
            TestClass.InitializeStaticObjectField(false);
            _ = TestClass.StaticObjectField.GetHashCode();

        }

        public void NullExceptionStaticDeref1Bad()
        {
            TestClass.InitializeStaticObjectField(true);
            _ = TestClass.StaticObjectField.GetHashCode();

        }

        public void NullExceptionStaticDeref2Ok()
        {
            TestClass.InitializeStaticObjectFieldViaReference(false);
            _ = TestClass.StaticObjectField.GetHashCode();

        }

        public void NullExceptionStaticDeref2Bad()
        {
            TestClass.InitializeStaticObjectFieldViaReference(true);
            _ = TestClass.StaticObjectField.GetHashCode();

        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }   
    }
}