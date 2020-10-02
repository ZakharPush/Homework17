using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_Task1
{
    class Program
    {
        public delegate void MyDelegate(int a, int b, int c);

        static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate(int a, int b, int c)
            {
                Console.WriteLine((a + b + c) / (double)3); 
            };

            myDelegate(4,5,7);

            Console.ReadKey();
        }
    }
}
