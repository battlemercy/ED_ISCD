using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_4_all
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите положительное натуральное число 'n', которое больше нуля: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    for (int i = 1; i < Math.Sqrt(n); i++) // обычные переменные
                    {
                        for (int year = 1; year < Math.Sqrt(n); year++)
                        {
                            for (int zombie = 1; zombie < Math.Sqrt(n); zombie++)
                            {
                                if (((i * i) + (year * year) + (zombie * zombie)) == n)
                                {
                                    Console.WriteLine(i + "^2" + " + " + year + "^2" + " + " + zombie + "^2" + " = " + n);
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("...");
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
