using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_2_for
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите натуральное положительное число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int kek = 0;
                for (int i = 100; i < 1000; i++)
                {
                    if (i / 100 + i % 100 / 10 + i % 10 == n)
                    {
                        kek++;
                    }
                }
                Console.WriteLine("Количество трёхзначных чисел, сумма цифр которых равна " + n + " : " + kek);
            }
            catch
            {
                Console.WriteLine("...");
            }
            Console.ReadKey();
        }
    }
}
