using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_1_all
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int kekw = 0;
                Console.WriteLine("Введите натуральное положительное число 'q', которое является площадью: ");
                int q = Convert.ToInt32(Console.ReadLine());
                if (q > 0)
                {
                    for (int i = 1; i < q; i++)
                    {
                        for (kekw = 1; kekw < q; kekw++)
                        {
                            if (i * kekw == q)
                            {
                                Console.WriteLine(i + " * " + kekw + " = " + q);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Площадь прямоугольника равен нулю и/или не может быть равен отрицательному значению!");
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
