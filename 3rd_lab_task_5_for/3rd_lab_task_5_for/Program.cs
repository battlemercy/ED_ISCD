using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_5_for
{
    class Program
    {
        static void Main(string[] args)
        {
                int kek = 0, lol1 = 0, lol2 = 0;
                for (int i = 10; i < 100; i++)
                {
                    lol1 = i % 10;
                    lol2 = i / 10;
                    if (lol1 + lol2 + Math.Pow(lol1 + lol2, 2) == i)
                    {
                        kek++;
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Поиск двухзначных чисел окончен.");
                Console.ReadKey();
        }
    }
}
