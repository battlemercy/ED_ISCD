using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_10_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, lol1 = 0;
            for (int i = 20; i < 100; i++)
            {
                lol1 = i % 10;
                if (i % 3 == 0 && (lol1 == 2 || lol1 == 4 || lol1 == 8))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Сумма целых положительных чисел равна: " + sum);
            Console.ReadKey();
        }
    }
}
