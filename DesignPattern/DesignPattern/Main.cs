using System;

namespace DesignPattern
{
    class MainRun
    {
        public static void Main(String[] args)
        {
            //Singleton Pattern
            var sing1 = Singleton.Instance();
            var sing2 = Singleton.Instance();

            Console.WriteLine(sing1 == sing2 ? "Same Object" : "Different Object");

            sing1.StrName = "Ant";
            sing2.StrName = "Bird";
            Console.WriteLine("sing1: {0}, sing2: {1}", sing1.StrName, sing2.StrName);
            // Wait for dispaly
            Console.ReadKey();

            //Template Method 
            var aA = new ConcreteClassA();
            aA.TemplateMethod();
            var aB = new ConcreteClassB();
            aB.TemplateMethod();
            var aC = new ConcreteClassC();
            aC.TemplateMethod();
            // Wait for dispaly
            Console.ReadKey();

            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);
            // Wait for dispaly
            Console.ReadKey();

            //AbstractFactory
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
            // Wait for dispaly
            Console.ReadKey();

            //State
            Context cA = new Context(new ConcreteStateA());
            Context cB = new Context(new ConcreteStateB());

            Console.WriteLine("+++++++++++++++++++++++");
            cA.Request();
            Console.WriteLine("+++++++++++++++++++++++");
            cA.Request();
            Console.WriteLine("+++++++++++++++++++++++");
            cA.Request();
            Console.WriteLine("+++++++++++++++++++++++");
            cA.Request();
            Console.WriteLine("+++++++++++++++++++++++");
            cB.Request();
            Console.WriteLine("+++++++++++++++++++++++");
            cB.Request();
            Console.WriteLine("+++++++++++++++++++++++");
            cB.Request();
            Console.WriteLine("+++++++++++++++++++++++");
            cB.Request();
            Console.WriteLine("+++++++++++++++++++++++");
            // Wait for dispaly
            Console.ReadKey();
        }
    }
}
