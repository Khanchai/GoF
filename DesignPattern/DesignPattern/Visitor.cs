using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    abstract class Visitor
    {
        public abstract void VisitConreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConreteElementB(ConcreteElementB concreteElementB);
    }

    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }

    class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConreteElementA(this);
        }

        public void OperationA()
        {
        }
    }

    class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConreteElementB(this);
        }
        public void OperationB()
        {
        }
    }

    class ConcreteVisitor1 : Visitor
    {
        public override void VisitConreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}",
                concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}",
                concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    class ConcreteVisitor2 : Visitor
    {
        public override void VisitConreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}",
                concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}",
                concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    class ObjectStructure
    {
        private List<Element> _elements = new List<Element>();

        public void Attach(Element element)
        {
            _elements.Add(element);
        }

        public void Detach(Element element)
        {
            _elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
