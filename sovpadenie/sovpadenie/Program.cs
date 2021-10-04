using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sovpadenie
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое число: ");
                int c = Convert.ToInt32(Console.ReadLine());
                if (a == b && a == c && b == c)
                {
                    Console.WriteLine("Совпадают все числа. 3.");
                }
                else if (a == b && a != c && b != c)
                {
                    Console.WriteLine("Совпадают два числа. 2.");
                }
                else if (b == c && b != a && c != a)
                {
                    Console.WriteLine("Совпадают два числа. 2.");
                }
                else if (a == c && a != b && c != b)
                {
                    Console.WriteLine("Совпадают два числа. 2.");
                }
                else
                {
                    Console.WriteLine("Числа не совпадают. 0.");   
                }
            }
            catch
            {
                Console.WriteLine("Программа не поняла Вас.");
            }
            Console.ReadKey();
        }
    }
}
