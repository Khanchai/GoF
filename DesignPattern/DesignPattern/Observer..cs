using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal abstract class Observer
    {
        public abstract void Update();
    }

    internal abstract class Subject 
    {
        private List<Observer> _observers = new List<Observer>(); 

        public void Attach(Observer observer)
        {
           _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
           _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.Update();
            }
        }
    }

    internal class ConcreteSubject : Subject
    {
        private string _SubjectState;

        public string SubjectState
        {
            get { return _SubjectState; }
            set { _SubjectState = value; }
        }
    }

    class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}",_name, _observerState);
        }
    }
}
