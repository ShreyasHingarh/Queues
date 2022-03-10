using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueWithArray<int> queue = new QueueWithArray<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
        }
    }
}
