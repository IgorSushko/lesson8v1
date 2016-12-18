using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraysizedef = 0;
            int actiontypeint = 0;
            
            int value2 = 0;


            Console.WriteLine("DynamicArray");
            Console.WriteLine("Please put initial size of Dinamic Array");
            arraysizedef = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysizedef];
            int[] arrayQ = new int[arraysizedef];
            int position = arraysizedef-1;
            Console.WriteLine("MyStack");
            Console.WriteLine("Please put number of action that you need");
            Console.WriteLine("1 -  IsEmpy");
            Console.WriteLine("2 -  IsFull");
            Console.WriteLine("3 -  Peek");
            Console.WriteLine("4 -  Push");
            Console.WriteLine("5 -  Pop");
            Console.WriteLine("MyQueue");
            Console.WriteLine("Please put number of action that you need");
            Console.WriteLine("6 -  IsEmpy");
            Console.WriteLine("7 -  IsFull");
            Console.WriteLine("8 -  Dequeue");
            Console.WriteLine("9 -  Enqueue");

            DynamicArray<int> stuckb1 = new DynamicArray<int>(array);
            DynamicArray<int> queues1 = new DynamicArray<int>(arrayQ);

            Buffer buf1 = new Buffer();
            MyStack<int> bs1 = new MyStack<int>(stuckb1, position, value2);
            
            MyQueue<int> qb1 = new MyQueue<int>(queues1);

            for (;;)
            {
                Console.WriteLine("put your number");
                actiontypeint = Convert.ToInt32(Console.ReadLine());
                switch (actiontypeint)
                {
                    case 1:
                        Console.WriteLine("Stuck is Empty");
                        Console.WriteLine(Convert.ToString(bs1.IsEmpty()));
                        break;

                    case 2:
                        Console.WriteLine("Stuck is Full");
                        Console.WriteLine(Convert.ToString(bs1.IsFull()));
                        break;

                    case 3:
                        Console.WriteLine("Current value in stuck is:");
                        Console.WriteLine(Convert.ToString(bs1.Peek()));
                        break;

                    case 4:
                        Console.WriteLine("put your value to stuck");
                        bs1.Push(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine("your took from stuck");
                        Console.WriteLine(Convert.ToString(bs1.Pop()));
                        break;

                    case 6:
                        Console.WriteLine("Queue is Empty");
                        Console.WriteLine(Convert.ToString(qb1.IsEmpty()));
                        break;

                    case 7:
                        Console.WriteLine(" Queue is Full");
                        Console.WriteLine(Convert.ToString(qb1.IsFull()));
                        break;

                    case 8:
                        Console.WriteLine("Current value in Queue is:");
                        Console.WriteLine(Convert.ToString(qb1.Dequeue()));
                        break;

                    case 9:
                        Console.WriteLine("put your value to Queue");
                        qb1.Enqueue(Convert.ToInt32(Console.ReadLine()));
                        break;

                }



               // Console.ReadLine();
            }
        }
    }
}
