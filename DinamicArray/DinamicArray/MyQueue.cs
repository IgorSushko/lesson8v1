using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicArray
{
    class MyQueue<T>:Buffer
    {
        DynamicArray<T> array;
        int head=0;
        int tail=0;
        int count = 0; //количество елементов в очереди


        public MyQueue(DynamicArray<T> array)
        {
            this.array = array;
           
        }
        // конструктор




        public override bool IsEmpty()
        {

            return array.Size() == 0;
        }

        public override bool IsFull()
        {
            return array.Capacity() == array.Size();
        }

        public void Enqueue(T value)
        {
            //int i=0;
            //i = head;
            if (head < array.Capacity() && count < array.Capacity())
            {
                //array[head] = value;
                array.Insert(head,value);
                head++;
                count++;
            }

            else
            {
                head = 0;
                if (IsFull()) { Console.WriteLine("Queue is full"); return; }
                //array[head] = value;
                array.Insert(head, value);
                head++;
                count++;
                

            }

            Console.WriteLine("head---" + head);
            Console.WriteLine("elements in queue---" + count);
            Console.WriteLine("*******************************");
        }

        public T Dequeue()
        {
            

            if (count == 0) { Console.WriteLine("Queue is empty "); return default (T); };
            T k = array.Get(tail);
            tail++;
            count--;
            Console.WriteLine("tail---" + tail);
            Console.WriteLine("elements in queue---" + count);

            //return array[k];
            return k;
        }
    }
}
