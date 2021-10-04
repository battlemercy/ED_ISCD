using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Появилась ошибка в следующем
            {   // блоке кода = переходим к следующему блоку кода 'catch'.
                Console.WriteLine("Введите длину стороны треугольника 'a': ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите длину стороны треугольника 'b': ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите длину стороны треугольника 'c': ");
                double c = Convert.ToDouble(Console.ReadLine());
                if (c * c > a * a + b * b) // квадраты сторон
                {
                    Console.WriteLine("Вид треугольника: тупоугольный!");
                }
                else if (c * c == a * a + b * b)
                {
                    Console.WriteLine("Вид треугольника: прямоугольный!");
                }
                else
                {
                    Console.WriteLine("Вид треугольника: остроугольный!");
                }
            }
            catch // продолжаем с этого блока кода.
            {
                Console.WriteLine("Сами леса Лордерона прошептали это имя - АРТАС!");
            }
            Console.ReadKey(); // check the results.
        }
    }
}
