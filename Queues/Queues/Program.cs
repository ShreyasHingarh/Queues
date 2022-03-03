using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueSomeone<int> queue = new QueueSomeone<int>();
            for(int i = 0;i < 31;i++)
            {
                queue.Enqueue(i);
                
            }

        }
    }
}
