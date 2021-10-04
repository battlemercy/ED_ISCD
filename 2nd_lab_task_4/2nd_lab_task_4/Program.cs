using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try // проверяем следующий блок кода на ошибки. Проходим, если нет ошибок.
            {
                Console.WriteLine("Введите 'x': "); // пользователь вводит x.
                double x = Convert.ToDouble(Console.ReadLine()); // записываем x.
                Console.WriteLine("Введите 'y': "); // пользователь вводит y.
                double y = Convert.ToDouble(Console.ReadLine()); // записываем y.
                if (x == 0 && y == 0) // пошла куча условий.
                {
                    Console.WriteLine("Точка лежит в нуле!");
                }
                else if (x == 0 && y != 0)
                {
                    Console.WriteLine("Точка лежит на оси y !");
                }
                else if (x != 0 && y == 0)
                {
                    Console.WriteLine("Точка лежит на оси x !");
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("Точка находится в первой четверти!");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Точка находится во второй четверти!");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Точка находится в третьей четверти!");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Точка находится в четвёртой четверти!");
                }
            }
            catch // произошла ошибка. Продолжаем с этого блока кода.
            {
                Console.WriteLine("Числа с остатком вводятся через запятую!");
            }
            Console.ReadKey(); // check the results.
        }
    }
}