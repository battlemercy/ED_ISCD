using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_6_for
{
    class Program
    {
        static void Main(string[] args)
        {
                int kek = 0, lol1 = 0, lol2 = 0;
                for (int i = 100; i < 1000; i++)
                {
                    lol1 = (int)Math.Pow(i, 2);
                    lol2 = lol1 % 1000;
                    if (lol2 == i)
                    {
                        kek++;
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Поиск трёхзначных чисел окончен.");
                Console.ReadKey();
        }
    }
}
