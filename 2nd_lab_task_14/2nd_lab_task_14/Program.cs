using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Появилась ошибка в следующем блоке кода =
            {   // переходим к следующему блоку кода 'catch'.
                Console.WriteLine("Введите число 'a': ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите число 'b': ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите число 'c': ");
                double c = Convert.ToDouble(Console.ReadLine());
                if (a > b && b >= c)
                {
                    a = a * 2;
                    b = b * 2;
                    c = c * 2;
                    Console.WriteLine("Удвоенные числа: a = " + a + "; b = " + b + "; c = " + c);
                }
                else
                {
                    a = Math.Abs(a);
                    b = Math.Abs(b);
                    c = Math.Abs(c);
                    Console.WriteLine("Модуль чисел: a = " + a + "; b = " + b + "; c = " + c);
                }
            }
            catch // произошла ошибка. Продолжение следует...
            {
                Console.WriteLine("ЗА МОЕГО ОТЦА!!");
            }
            Console.ReadKey();
        }
    }
}
