using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class QueueSomeone<T>
    {
        public int Count { get; private set; }
        private LinkedList<T> data = new LinkedList<T>();

        public void Enqueue(T value) 
        {
            data.AddLast(value);
        }
        public T Dequeue() 
        {
            T value = data.First.Value;
            data.RemoveFirst();
            return value;
        }
        public T Peek() 
        {
            return data.First.Value;
        }

    }
}
