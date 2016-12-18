using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicArray
{
    class MyStack<T>:Buffer
    {
        int position;
        DynamicArray<T> array;
        int value;


        public MyStack(DynamicArray<T> array, int position, int value)
        {
            this.array = array;
            this.position = position;
            this.value = value;
        }
        // конструктор


        public override bool IsFull()
        {
            return position < 0;
        }

        public override bool IsEmpty()
        {
            return array.Size()==0;
        }

        public void Push(T value)
        {
            if (position < 0)
            {
                Console.WriteLine("Stek is full ");

                return;
            }
            //array[position] = value;
            array.Insert(position,value);
            position--;
        }

        public T Pop()
        {
            if (IsEmpty()) { Console.WriteLine("Stek is empty "); return default(T); }
            if (position == array.Capacity()-1) { Console.WriteLine("Stek is empty "); return default(T); }
            //return array[++position];
            return array.Get(++position);

        }

        public T Peek()
        {
            int temp3 = 0;
            if (position == 5) { Console.WriteLine("Stek is empty ");  return default(T); }
            if (position < 0) { Console.WriteLine("Stek is full "); return array.Get(0); }   //return array[0];
            temp3 = position + 1;
            //return array[temp3];
            return array.Get(temp3);
        }

    }
}
