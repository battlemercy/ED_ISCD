using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try // проверяем следующий блок кода на ошибки. Выполняем, если не возникла ошибка.
            {
                Console.WriteLine("Введите длину стороны треугольника 'a': "); // вводим
                double a = Convert.ToDouble(Console.ReadLine()); // записываем
                Console.WriteLine("Введите длину стороны треугольника 'b': ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите длину стороны треугольника 'c': ");
                double c = Convert.ToDouble(Console.ReadLine());
                if (a < 0 || b < 0 || c < 0) // поiхали
                {
                    Console.WriteLine("Длина стороны треугольника не может быть отрицательной!");
                }
                else if (a == 0 || b == 0 || c == 0)
                {
                    Console.WriteLine("Треугольника не существует!");
                }
                else if (a == b && b == c && a == c)
                {
                    Console.WriteLine("Вид треугольника: равносторонний.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Вид треугольника: равнобедренный.");
                }
                else if (a != b && a != c && b != c)
                {
                    Console.WriteLine("Вид треугольника: разносторонний.");
                }
            }
            catch // произошла ошибка. Продолжение следует...
            {
                Console.WriteLine("ОП, пiймав на гендзюцу! (Числа с остатком вводи через запятую!)");
            }
            Console.ReadKey(); // check this out!
        }
    }
}
