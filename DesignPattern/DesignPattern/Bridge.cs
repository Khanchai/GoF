
using System;

namespace DesignPattern
{
    abstract class Implementor
    {
        public abstract void OperationImp();
    }

    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.OperationImp();
        }
    }

    internal class ConcreteImplementorA : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }

     class ConcreteImplementorB : Implementor  
     {
         public override void OperationImp()
         {
             Console.WriteLine("ConcreteImplementorB Operation");
         }
     }

    internal class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
}
