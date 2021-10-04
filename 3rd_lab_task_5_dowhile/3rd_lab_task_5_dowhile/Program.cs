using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_5_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите положительное натуральное число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0, i = 1;
                do
                {
                    if (n % i == 0)
                    {
                        sum = sum + i;
                    }
                    i++;
                }
                while (i < n-1);
                if (n == sum)
                {
                    Console.WriteLine("Число " + n + " совершенное!");
                }
                else
                {
                    Console.WriteLine("Число " + n + " не совершенное!");
                }
            }
            catch
            {
                Console.WriteLine("...");
            }
            Console.ReadKey();
        }
    }
}
