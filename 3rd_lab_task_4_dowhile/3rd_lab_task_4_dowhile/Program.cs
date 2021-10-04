using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_4_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0, b = 1, c = 0, sum = 1;
                do
                {
                    sum = sum + c;
                    c = a; // n
                    a = b; // n-2
                    b += c; // n-1
                }
                while (c <= 1000);
                Console.WriteLine("Сумма чисел Фибоначчи = " + sum);
            }
            catch
            {
                Console.WriteLine("...");
            }
            Console.ReadKey();
        }
    }
}
