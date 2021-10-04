using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целое положительное число 'n': ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое положительное число 'm': ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Сколько долек нужно отломить?");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k > 0 && n > 0 && m > 0)
                {
                    if ((k % n == 0 || k % m == 0) && k < n * m)
                    {
                        Console.WriteLine("YES.");
                    }
                    else
                    {
                        Console.WriteLine("NO.");
                    }
                }
                else
                {
                    Console.WriteLine("Программа не поняла Вас.");
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
