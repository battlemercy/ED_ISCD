using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_8_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целое положительное число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int count = 0; // счётчик нечётных.
                if (n > 0)
                {
                    do
                    {
                            if (n % 2 == 1)
                            {
                                count++;
                                n = n / 10;
                            }
                            else
                            {
                                n = n / 10;
                            }
                    }
                    while (n != 0);
                }
                Console.WriteLine("Количество нечётных цифр: " + count);
            }
            catch
            {
                Console.WriteLine("Только безработные и бездельники постоянно чем-то заняты.");
            }
            Console.ReadKey();
        }
    }
}
