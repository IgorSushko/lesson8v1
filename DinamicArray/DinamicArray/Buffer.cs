using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicArray
{
    class Buffer
    {

        public virtual bool IsFull() {
            Console.WriteLine("This method should be ovveriden in child class");
            return true;
        }


        public virtual bool IsEmpty() {
            Console.WriteLine("This method should be ovveriden in child class2");
            return true;
        }


    }
}
