using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_Task3
{
    class Program
    {
        public delegate int MyDelegate(int a, int b);

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть перше число");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть знак арифметичної операції");
            string  sign = Console.ReadLine();

            Console.WriteLine("Введіть друге число");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            switch (sign)
            {
                case "+": 
                    MyDelegate Add = (x, y) => x + y;
                    Console.WriteLine($"Результат : {Add(firstNumber, secondNumber)}");
                    break;

                case "-":
                    MyDelegate Sub = (x, y) => x - y;
                    Console.WriteLine($"Результат : {Sub(firstNumber, secondNumber)}");
                    break;

                case "*":
                    MyDelegate Mul = (x, y) => x * y;
                    Console.WriteLine($"Результат : {Mul(firstNumber, secondNumber)}");
                    break;

                case "/":
                    MyDelegate Div = (x, y) =>
                    {
                        if (y != 0)
                        {
                            return x / y;
                        }
                        else
                        {
                            Console.WriteLine("На 0 ділити не можна");
                        }
                        return 0;
                    };
                    Console.WriteLine($"Результат : {Div(firstNumber, secondNumber)}");
                    break;

                default:
                    Console.WriteLine("Введена дія не існує");
                    break;
            }

            Console.ReadKey();
        }
    }
}
