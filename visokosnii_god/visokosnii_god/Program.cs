using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visokosnii_god
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целый положительный номер года: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    if (n % 4 == 0 && n % 100 != 0 || n % 400 == 0)
                    {
                        Console.WriteLine("Этот год является високосным! YES!");
                    }
                    else
                    {
                        Console.WriteLine("Этот год не является високосным! NO!");
                    }
                }
                else
                {
                    Console.WriteLine("Программа не поняла Вас.");
                }
            }
            catch
            {
                Console.WriteLine("Программа не поняла Вас."); ;
            }
            Console.ReadKey();
        }
    }
}
