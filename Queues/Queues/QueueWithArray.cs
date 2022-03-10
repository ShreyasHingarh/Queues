using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class QueueWithArray <T>
    {
        
        private T[] data = new T[3];
        private int headIndex;
        private int tailIndex;
        public int Count
        {
            get
            { 
                if(tailIndex > headIndex || (tailIndex == 0 && headIndex == 0))
                {
                    return tailIndex - headIndex;
                }
                return data.Length - headIndex + tailIndex;
            }
        }

        public void Enqueue(T value)
        {
            
            if ( (headIndex == tailIndex || (headIndex == 0 && tailIndex > data.Length - 1)) && Count > 0)
            {
                Resize(data.Length * 2);
            }
            else if (tailIndex > data.Length - 1)
            {
                tailIndex = 0;
            }

            
            data[tailIndex] = value;
            tailIndex++;
            
         
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
                
                Resize(data.Length /2);
                return;
            }
            

        }
        public T Peek() 
        {
            return data[headIndex];
        }

        private void Resize(int size)
        {
            T[] temp = new T[size];

            int index = 0;
            if (headIndex < tailIndex)
            {
                for (int i = headIndex; i < tailIndex; i++)
                {
                    temp[index] = data[i];
                    index++;
                }
                
            }
            else if(headIndex >= tailIndex)
            {
               
                for(int i = headIndex;i < data.Length;i++)
                {
                    temp[index] = data[i];
                    index++;
                }
                for(int i = 0;i < tailIndex;i++)
                {
                    temp[index] = data[i];
                    index++;
                }
                
            }
            tailIndex = index;
            data = temp;            
            headIndex = 0;
           
        }
       

    }
}
