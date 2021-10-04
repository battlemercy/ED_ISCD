using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_10_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите ограничение(число 'Z'): ");
                int z = Convert.ToInt32(Console.ReadLine());
                int sum = 0, n = 1;
                do
                {
                        sum = sum + (int)Math.Pow(n, 2);
                        n = n + 2;
                }
                while (sum < z);
                Console.WriteLine("Сумма квадратов первых нечётных чисел: " + sum);
            }
            catch
            {
                Console.WriteLine("Только безработные и бездельники постоянно чем-то заняты.");
            }
            Console.ReadKey();
        }
    }
}
