using ProjectA;

namespace ProjectB
{
    public class Class1: PublicAbstractClass
    {
        public void Test()
        {
            var publicClass = new PublicClass();
            publicClass.PublicMethod();
            //publicClass.PublicInternalVoid();//só funciona se estiver no mesmo assembly
            //publicClass.PrivateMethod();

            //var publicAbstractClass = new PublicAbstractClass();

            ProtectedMethod();
            ProtectedInternalMethod();

            //var publicInternalClass = new PublicInternalClass();//só funciona se estiver no mesmo assembly

            //var privateClass = new PrivateClass();//só funciona se estiver no mesmo assembly
            //privateClass.PublicMethod();//só funciona se estiver no mesmo assembly
            //privateClass.PrivateMethod();

            var SealedClass = new SealedClass();
        }
    }

    class Class2 : PrivateAbstractClass//só funciona se estiver no mesmo assembly
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
}
