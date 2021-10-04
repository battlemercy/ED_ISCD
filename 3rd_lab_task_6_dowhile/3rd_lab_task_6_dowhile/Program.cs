using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_6_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n, sum = 0, i = 1;
                do
                {
                    Console.WriteLine("Введите натуральное число: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n > 0 && i % 2 == 1)
                    {
                        sum = sum + n;
                    }
                    i++;
                }
                while (n != 0);
                Console.WriteLine("Сумма положительных элементов последовательности: " + sum);
            }
            catch
            {
                Console.WriteLine("...");
            }
            Console.ReadKey();
        }
    }
}
