using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_lab_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = 0, number1 = 0, number2 = 0, sum = 0; // пользователь может вводить целые и дробные числа.
            Console.WriteLine("Пользователь, введи в меня своё число: "); // программа просит ввести число.
            try // следующий блок кода проверяется на наличие ошибок. Если их не было, то он успешно выполняет его.
            {
                number = Convert.ToSingle(Console.ReadLine()); // введённое число записывается в "number". Convert.ToSingle - Преобразует заданное значение в число с плавающей запятой одиночной точности.
                number1 = number + 1; // значение+1
                number2 = number + 2; // значение+2
                sum = number + number1 + number2; // сумма
                Console.WriteLine("Введённое значение: " + number); // расписываем пользователю, какие шаги были сделаны в результате.
                Console.WriteLine("Значение, увеличенное на единицу: " + number1);
                Console.WriteLine("Значение, увеличенное на два: " + number2);
                Console.WriteLine("Сумма этих трёх значений: " + sum);
            }
            catch // если возникла ошибка, то он продолжает с этого куска кода.
            {
                Console.WriteLine("Ты попал в странное место! Сюда можно попасть, если ты ввёл не число, или число с дробной частью не через запятую!");
            }
            Console.ReadKey(); // смотрим результаты.
        }
    }
}
