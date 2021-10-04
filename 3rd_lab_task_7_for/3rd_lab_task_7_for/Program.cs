using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_7_for
{
    class Program
    {
        static void Main(string[] args)
        {
                for (int i = 1000; i < 10000; i++)
                {
                    if (i % 133 == 125 && i % 134 == 111)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Поиск четырёхзначных чисел окончен.");
                Console.ReadKey();
        }
    }
}
