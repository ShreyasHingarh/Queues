using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class QueueWithArray <T>
    {
        public int Count { get; private set; }
        private T[] data = new T[5];
        private int headIndex;
        private int tailIndex;

        public void Enqueue(T value)
        { 

            if(headIndex >= 1)
            {
                headIndex--;
            }
            if(tailIndex == headIndex - 1|| tailIndex == data.Length )
            {
                Resize(data.Length * 2);
            }
            if(tailIndex > data.Length - 1)
            {
                tailIndex = tailIndex % data.Length;
            }
            data[tailIndex] = value;
            tailIndex++;
            Count++;
        }
        public void Dequeue()
        {
            headIndex++;
            if(headIndex > data.Length)
            {
                headIndex = 0;
            }
            if(0.25f * data.Length == Count)
            {
                Resize((int)(data.Length * 0.5f));
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
            for (int i = 0; i < data.Length; i++)
            {
                temp[i] = data[i];
            }
            data = temp;
        }
       

    }
}
