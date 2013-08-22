using System;

namespace DesignPattern
{
    internal abstract class ComponentDecorator
    {
        public abstract void Operation();
    }

    abstract class Decortor : ComponentDecorator
    {
        protected ComponentDecorator Component;

        public void SetComponent(ComponentDecorator component)
        {
            this.Component = component;
        }

        public override void Operation()
        {
            if (Component != null)
            {
                Component.Operation();
            }
        }
    }

    class ConcreteComponent : ComponentDecorator
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }

    class ConcreteDecoratorA : Decortor
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }

    class ConcreteDecoratorB : Decortor
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }
        void AddedBehavior()
        {
        }
    }
}

