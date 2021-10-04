using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_7_all
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите натуральное положительное число 'a': ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите натуральное положительное число 'b': ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a > 0 && b > 0)
                {
                    Console.WriteLine("Числа, которые удовлетворяют неравенству: ");
                    if (a < b)
                    {
                        while (a <= b)
                        {
                            Console.WriteLine(a);
                            a++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("...");
                    }
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
