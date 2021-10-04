using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_3_for
{
    class Program
    {
        static void Main(string[] args)
        {
                int kek = 0, sum = 0;
                for (int i = 25; i < 126; i++)
                {
                    kek = (int)Math.Pow(i, 3);
                    sum = sum + kek;
                }
                Console.WriteLine("Сумма кубов чисел от 25 до 125 равна: " + sum);
                Console.ReadKey();
        }
    }
}
