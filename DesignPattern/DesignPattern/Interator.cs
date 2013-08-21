using System.Collections;

namespace DesignPattern
{
    internal abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    internal abstract class Aggregate
    {
        public abstract  Iterator CreateIterator();
    }

    class ConcreateAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }

    class ConcreteIterator : Iterator
    {
        private ConcreateAggregate _aggregate;
        private int _current = 0;

        // Constructor
        public ConcreteIterator(ConcreateAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;

        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }
    }




}
