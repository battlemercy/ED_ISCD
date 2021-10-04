using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_2_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Какое положительное число Фибоначчи хотите найти?");
                int n = Convert.ToInt32(Console.ReadLine());
                int a = 0, b = 1, i = 0, c = 0;
                if (n > 0)
                {
                    do
                    {
                        c = a; // n
                        a = b; // n-2
                        b += c; // n-1
                        i++;
                    }
                    while (i <= n);
                    Console.WriteLine("Число Фибоначчи " + n + ": " + c);
                }
                else
                {
                    Console.WriteLine("...");
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
