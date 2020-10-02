using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_Task4
{
    public delegate int Number();
    public delegate int MyDelegate(Number[] arr);

    class Program
    {
        public static int GetRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 20);
        }

        static void Main(string[] args)
        {
            Number[] myNumber = new Number[5];

            for (int i = 0; i < myNumber.Length; i++)
            {
                myNumber[i] = GetRandomNumber;
                Console.WriteLine(myNumber[i]());
            }

            Console.WriteLine();

            MyDelegate myDelegate = delegate (Number[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i]();
                }
                return ((sum) / (arr.Length));
            };
            Console.WriteLine($"Середнє арифметичне : {myDelegate(myNumber)}");

            Console.ReadKey();
        }
    }
}
