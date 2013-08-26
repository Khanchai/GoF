using System;

namespace DesignPattern
{
    class ContextInterperter
    {
    }

    abstract class AbstractExpression
    {
        public abstract void Interperter(ContextInterperter context);
    }

    class TerminalExpression : AbstractExpression
    {
        public override void Interperter(ContextInterperter context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }

    class NonterminalExpression : AbstractExpression
    {
        public override void Interperter(ContextInterperter context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }

}
