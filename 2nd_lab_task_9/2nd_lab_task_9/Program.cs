using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. 
            {   // Появилась ошибка в следующием блоке кода = переходим к ближайшему блоку 'catch'.
                Console.WriteLine("Введите число 'a': ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите число 'b': ");
                double b = Convert.ToDouble(Console.ReadLine());
                string action; // играет роль переключателя.
                Console.WriteLine("Введите указанное действие над введёнными числами ( + или - или * или / ): ");
                action = Console.ReadLine();
                double result = 0;
                switch (action) // оператор выбора, который сравнивает введённое в переменную 'action'
                {               // с заданным значениям case'ов.
                    case "+": // если совпало, то заходим в этот case.
                        result = a + b; // Если не совпало, двигаемся дальше по case'ам.
                        Console.WriteLine("Сумма двух чисел равна: " + result);
                        break; // выходим из оператора switch-case.
                    case "-": // это как if-else.
                        result = a - b;
                        Console.WriteLine("Разность двух чисел равна: " + result);
                        break;
                    case "*":
                        result = a * b;
                        Console.WriteLine("Произведение двух чисел равна: " + result);
                        break;
                    case "/":
                        result = a / b;
                        Console.WriteLine("Частное двух чисел равна: " + result);
                        break;
                    default: // если ничего не подошло, мы переходим к 'default'.
                        Console.WriteLine("Произошла ошибка!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("ЗА ААААЛЬЯЯЯЯЯНС!!");
            }
            Console.ReadKey(); // check the results.
        }
    }
}
