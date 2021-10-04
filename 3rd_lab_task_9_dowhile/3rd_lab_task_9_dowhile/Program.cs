using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_9_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целое положительное число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int kek = 0;
                if (n > 0)
                {
                    do
                    {
                        kek = n % 10;
                        n = n / 10;
                    }
                    while (n != 0);
                    Console.WriteLine("Первая цифра: " + kek);
                }
                else
                {
                    Console.WriteLine("Только безработные и бездельники постоянно чем-то заняты.");
                }
            }
            catch
            {
                Console.WriteLine("Только безработные и бездельники постоянно чем-то заняты.");
            }
            Console.ReadKey();
        }
    }
}
