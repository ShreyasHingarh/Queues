using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class QueueWithArray <T>
    {
        public int Count { get; private set; }
        private T[] data = new T[3];
        private int headIndex;
        private int tailIndex;

        public void Enqueue(T value)
        {
            tailIndex++;

            if ((tailIndex == headIndex || tailIndex == data.Length) && Count > 0)
            {
                Resize(data.Length * 2);
            }
            if(tailIndex > data.Length - 1)
            {
                tailIndex = 0;
            }
            data[tailIndex] = value;
          
            Count++;
        }
        public void Dequeue()
        {
            headIndex++;
            
            if (headIndex > data.Length)
            {
                headIndex = 0;
            }
            if( data.Length /4== Count)
            {
                Count--;
                Resize(data.Length /2);
                return;
            }
            Count--;

        }
        public T Peek() 
        {
            return data[headIndex];
        }

        private void Resize(int size)
        {
            T[] temp = new T[size];
            if(headIndex < tailIndex)
            {
                int index = 0;
                for (int i = headIndex; i < tailIndex; i++)
                {
                    temp[index] = data[i];
                    index++;
                }
            }
            if(headIndex > tailIndex)
            {
                for(int i = headIndex;i < data.Length;i++)
                {
                    temp[i] = data[i];
                }
                for(int i = 0;i < tailIndex;i++)
                {
                    temp[i] = data[i];
                }
                
            }
            tailIndex = Count ;
            headIndex = 0;
            data = temp;
        }
       

    }
}
