using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_1_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите ограничение: ");
                int p = Convert.ToInt32(Console.ReadLine());
                int mn = 1, count = 0, n = 0;
                do
                {
                    Console.WriteLine("Введите нечётное целое положительное число: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n > 0 && n % 2 == 1)
                    {
                        mn = mn * n;
                        count++;
                    }
                }
                while (p > mn);
                Console.WriteLine("Последний сомножитель: " + n + ", общее кол-во сомножителей: " + count + ", произведение: " + mn);
            }
            catch
            {
                Console.WriteLine("...");
            }
            Console.ReadKey();
        }
    }
}
