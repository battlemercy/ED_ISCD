using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_4_for
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
                    if ((Math.Pow(lol1, 2) + Math.Pow(lol2, 2)) % 13 == 0)
                    {
                        kek++;
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Всего двузначных чисел, которые верны условию: " + kek);
                Console.ReadKey();
        }
    }
}
