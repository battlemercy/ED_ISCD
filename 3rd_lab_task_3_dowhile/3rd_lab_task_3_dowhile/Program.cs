using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_3_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число 'm': ");
                int m = Convert.ToInt32(Console.ReadLine());
                int a = 0, b = 1, c = 0, n = -1;
                    do
                    {
                    c = a; // n
                    a = b; // n-2
                    b += c; // n-1
                    n++;
                    }
                    while (c <= m);
                    Console.WriteLine("Число Фибоначчи, которое больше m = " + m + " : " + c + "; n = " + n);
            }
            catch
            {
                Console.WriteLine("...");
            }
            Console.ReadKey();
        }
    }
}
