using System;

namespace DesignPattern
{

    abstract class AbstractClassDemo
        {
            public abstract void PrimitiveOperation1();
            public abstract void PrimitiveOperation2();

            public void TemplateMethod()
            {
                PrimitiveOperation1();
                PrimitiveOperation2();
                Console.WriteLine("++++++++");
            }
        }

    class ConcreteClassA : AbstractClassDemo
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        }
    }
    class ConcreteClassB : AbstractClassDemo
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");


        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
    }

    class ConcreteClassC : AbstractClassDemo
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassC.PrimitiveOperation1()");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassC.PrimitiveOperation2()");
        }
    }

}
