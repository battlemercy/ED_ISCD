using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Появилась ошибка в следующем блоке кода
            {   // = переходим к следующему блоку кода 'catch'.
                Console.WriteLine("Введите 'x': ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите 'y': ");
                double y = Convert.ToDouble(Console.ReadLine());
                if (x < 0 && y < 0)
                {
                    x = Math.Abs(x);
                    y = Math.Abs(y);
                    Console.WriteLine("Модули чисел: x = " + x + "; y = " + y);
                }
                else if ((x < 0 && y > 0) || (x > 0 && y < 0))
                {
                    x = x + 0.5;
                    y = y + 0.5;
                    Console.WriteLine("x = " + x + "; y = " + y);
                }
                else if ((x > 0 && y > 0) && ((y < 0.5 || y > 2) || (x < 0.5 || x > 2)))
                {
                    x = x / 10;
                    y = y / 10;
                    Console.WriteLine("x = " + x + "; y = " + y);
                }
                else
                {
                    Console.WriteLine("x = " + x + "; y = " + y);
                }
            }
            catch // произошла ошибка. Продолжение следует...
            {
                Console.WriteLine("THIS POWER IS MINE!!");
            }
            Console.ReadKey(); // check the results.
        }
    }
}
