using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicArray
{
    class DynamicArray<T> // note
    {
        T[] array;
        int maxsize = 200;
        int arraysize = 0;
        public DynamicArray(T[] array)
        {
            this.array = array;
        }
        //**************CAPACITY****************************************************

        public int Capacity()
        {
            return array.Length;
        }

        //*************SIZE*********************************************************
        public int Size()
        {
            return arraysize;
        }

        //************REMOVE*******************************************************

        public void Remove(int index2)
        {
            pushtoOnedel(index2);
            arraysize--;


        }


        //************GET**********************************************************

        public T Get(int index3)
        {
            return array[index3];
        }


        //*************************INSERT*****************************************
        public int Insert(int index1, T value)
        {
            if (arraysize == array.Length)
            {
                expand();
                pushtoOne(index1);
                array[index1] = value;
                arraysize++;
                return 1;
            }

            //pushtoOne(index1);
            array[index1] = value;
            arraysize++;
            return 1;

        }

        //*******************ADD*****************************************************

        public int Add(T value)
        {
            if (arraysize == array.Length)
            {
                expand();
                array[arraysize] = value; //see arraysize might be need to make -1
                arraysize++;
                return 1;
            }
            if (arraysize > maxsize)
            {
                Console.WriteLine("array overflow");
                return 1;
            }
            array[arraysize] = value;
            arraysize++;
            return 1;
        }
        //**********************************************************************************		
        private void expand()
        {
            T[] arraynew = new T[arraysize * 2];
            for (int i = 0; i < arraysize; i++)
            {
                arraynew[i] = array[i];

            }
            array = arraynew;
            Console.WriteLine("array becomes bigger");


        }

        private void shrink()
        {
            T[] arraynew = new T[(arraysize * 3) / 4];  // delete end after divide
            for (int i = 0; i < arraysize; i++)
            {
                arraynew[i] = array[i];

            }
            array = arraynew;
            Console.WriteLine("array becomes shorter");
        }

        private void pushtoOne(int index)
        {
            for (int i = arraysize; i == arraysize - index; i--)
            {
                array[i + 1] = array[i];

            }

        }


        private void pushtoOnedel(int index)
        {
            for (int i = index; i == arraysize - 1; i++)
            {
                array[i] = array[i + 1];

            }

        }



    }
}
