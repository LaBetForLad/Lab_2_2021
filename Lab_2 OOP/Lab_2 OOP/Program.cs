using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        delegate void oprration(int x);
        static oprration[] arr = new oprration[3];
        static void Main(string[] args)
        {
            Console.WriteLine("Наберите цифру от 0 до 2 ");
            Console.WriteLine("Затем, через пробел, нужное число для расчёта");
            Console.WriteLine("0 -- sqrt(abs(x))");
            Console.WriteLine("1 -- x^3");
            Console.WriteLine("2 -- x + 3,5"); 
            arr[0] = (x) => Console.WriteLine(Math.Sqrt(Math.Abs(x)));
            arr[1] = (x) => Console.WriteLine(Math.Pow(x, 3));
            arr[2] = (x) => Console.WriteLine(x + 3.5);

            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');

                try
                {
                    int firstNum = int.Parse(str[0]);
                    int x = int.Parse(str[1]);

                    arr[firstNum](x);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("К сожалению данные введены некорректно");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
