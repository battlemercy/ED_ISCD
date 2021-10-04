using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waterpool
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целое положительное число 'n', длина бассейна: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое положительное число 'm', ширина бассейна: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое положительное число 'x', расстояние от одного из длинных бортиков: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое положительное число 'y', расстояние от одного из коротких бортиков: ");
                int y = Convert.ToInt32(Console.ReadLine());
                int nx = 0, my = 0;
                if (n > 0 && m > 0 && x > 0 && y > 0)
                {
                    if (x >= n / 2)
                    {
                        nx = n - x; // расстояние до ближайшего длинного бортика.
                    }
                    else
                    {
                        nx = x;
                    }
                    if (y >= m / 2)
                    {
                        my = m - y; // расстояние до ближайшего короткого бортика.
                    }
                    else
                    {
                        my = y;
                    }
                    if (nx <= my)
                    {
                        Console.WriteLine("Илье нужно проплыть " + nx + " метров.");
                    }
                    else
                    {
                        Console.WriteLine("Илье нужно проплыть " + my + " метров.");
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