using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naimenjshee
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double min = 0;
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Введите число: ");
                    double n = Convert.ToDouble(Console.ReadLine());
                    if (n < min)
                    {
                        min = n;
                    }
                }
                Console.WriteLine("Наименьшее число: " + min);
            }
            catch
            {
                Console.WriteLine("Программа не поняла Вас.");
            }
            Console.ReadKey();
        }
    }
}
