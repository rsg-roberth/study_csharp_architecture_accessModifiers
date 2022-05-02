using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectB")]
namespace ProjectA
{
    public class PublicClass
    {
        public void PublicMethod() { }
        internal void PublicInternalVoid() { }
        private void PrivateMethod() { }
    }

    public abstract class PublicAbstractClass
    {
        protected void ProtectedMethod() {}
        protected internal void ProtectedInternalMethod() { }
    }

    abstract class PrivateAbstractClass
    {
        protected void ProtectedMethod() { }
        protected internal void ProtectedInternalMethod() { }
    }

    internal class PublicInternalClass { }

    class PrivateClass
    {
        public void PublicMethod() { }
        private void PrivateMethod() { }
    }

    public sealed class SealedClass { }

    //public class TestHeritageSealed : SealedClass { }

    public class TestModifiers1 : PublicAbstractClass { 
        public void Tests()
        {
            var publicClass = new PublicClass();
            publicClass.PublicMethod();
            publicClass.PublicInternalVoid();
            //publicClass.PrivateMethod();

            //var publicAbstractClass = new PublicAbstractClass();

            ProtectedMethod();
            ProtectedInternalMethod();

            var publicInternalClass = new PublicInternalClass();

            var privateClass = new PrivateClass();
            privateClass.PublicMethod();
            //privateClass.PrivateMethod();

            var SealedClass = new SealedClass();

        }    
    }

    class TestModifiers2 : PrivateAbstractClass
    {
        public void Tests()
        {
            var publicClass = new PublicClass();
            publicClass.PublicMethod();
            publicClass.PublicInternalVoid();
            //publicClass.PrivateMethod();

            //var privateAbstractClass = new PrivateAbstractClass();

            ProtectedMethod();
            ProtectedInternalMethod();

            var publicInternalClass = new PublicInternalClass();

            var privateClass = new PrivateClass();
            privateClass.PublicMethod();
            //privateClass.PrivateMethod();

            var SealedClass = new SealedClass();
        }
    }

    class TestModifiers3
    {
        public void Tests()
        {
            var publicClass = new PublicClass();
            publicClass.PublicMethod();
            publicClass.PublicInternalVoid();
            //publicClass.PrivateMethod();

            //var privateAbstractClass = new PrivateAbstractClass();

            var testModifiers2 = new TestModifiers2();
            //testModifiers2.ProtectedMethod();
            testModifiers2.ProtectedInternalMethod();

            var publicInternalClass = new PublicInternalClass();

            var privateClass = new PrivateClass();
            privateClass.PublicMethod();
            //privateClass.PrivateMethod();

            var SealedClass = new SealedClass();
        }
    }

}
