using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueWithArray<int> queue = new QueueWithArray<int>();
            for(int i = 0;i < 31;i++)
            {
                queue.Enqueue(i);
                
            }
            ;

        }
    }
}
