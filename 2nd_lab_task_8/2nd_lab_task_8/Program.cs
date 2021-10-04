using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try // проверяем следующий блок кода на ошибки. Выполняем, если не возникла ошибка.
            {
                Console.WriteLine("Введите 'x1': ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите 'y1': ");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите 'x2': ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите 'y2': ");
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите 'x3': ");
                double x3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите 'y3': ");
                double y3 = Convert.ToDouble(Console.ReadLine());
                x1 = Math.Abs(x1); // модуль важен, т.к.
                x2 = Math.Abs(x2); // при отрицательных
                x3 = Math.Abs(x3); // значениях программа
                y1 = Math.Abs(y1); // без модулей запутается
                y2 = Math.Abs(y2); // и даст неверный ответ.
                y3 = Math.Abs(y3);
                if ((x1 + y1) < (x2 + y2) && (x1 + y1) < (x3 + y3))
                {
                    Console.WriteLine("Точка с координатами (" + x1 + "; " + y1 + ") - ближе всех расположена к началу координат!");
                }
                else if ((x2 + y2) < (x1 + y1) && (x2 + y2) < (x3 + y3))
                {
                    Console.WriteLine("Точка с координатами (" + x2 + "; " + y2 + ") - ближе всех расположена к началу координат!");
                }
                else if ((x3 + y3) < (x1 + y1) && (x3 + y3) < (x2 + y2))
                {
                    Console.WriteLine("Точка с координатами (" + x3 + "; " + y3 + ") - ближе всех расположена к началу координат!");
                }
                else
                {
                    Console.WriteLine("Несколько из точек расположены одинаково близко!");
                }
            }
            catch
            {
                Console.WriteLine("ЗА ОРДУУУУУУУ!");
            }
            Console.ReadKey();
        }
    }
}
