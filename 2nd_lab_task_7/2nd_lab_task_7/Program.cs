using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try // проверяем следующий блок кода на ошибки. Выполняем, если не возникла ошибка.
            {
                Console.WriteLine("Введите длину стороны квадрата 'a': ");
                double a = Convert.ToDouble(Console.ReadLine()); // преобразуем из строкового в 
                Console.WriteLine("Введите радиус круга 'r': "); // равное число с плавающей 
                double r = Convert.ToDouble(Console.ReadLine()); // запятой двойной точности.
                double dia_kv = Math.Sqrt(a + a); // находим диагональ квадрата.
                double dia_kr = r + r; // находим диагональ круга.
                if (dia_kr >= dia_kv) // сравниваем диагонали.
                { // диагональ круга должна быть больше диагонали квадрата
                    Console.WriteLine("Данный квадрат поместится в круг!"); 
                }
                else
                {
                    Console.WriteLine("Данный квадрат не поместится в круг!");
                }
            }
            catch // произошла ошибка. Продолжение следует...
            {
                Console.WriteLine("Тут не место символам и пустым строчкам! МЫ - АНТИПУСТОТА!");
            }
            Console.ReadKey(); // check the results!
        }
    }
}
