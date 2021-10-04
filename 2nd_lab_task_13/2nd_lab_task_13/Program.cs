using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Появилась ошибка в следующем блоке кода
            {   // = переходим к следующему блоку кода 'catch'.
                Console.WriteLine("Введите целое число");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n) // оператор выбора, который сравнивает введённое в переменную
                { // 'n' с заданными значениями case'ов.
                    case 0: // если совпало, то заходим в этот case.
                        Console.WriteLine("Нуль!");
                        break; // выходим из оператора switch-case.
                    case 1:
                        Console.WriteLine("Один!");
                        break;
                    case 2:
                        Console.WriteLine("Два!");
                        break;
                    case 3:
                        Console.WriteLine("Три!");
                        break;
                    case 4:
                        Console.WriteLine("Четыре!");
                        break;
                    case 5:
                        Console.WriteLine("Пять!");
                        break;
                    case 6:
                        Console.WriteLine("Шесть!");
                        break;
                    case 7:
                        Console.WriteLine("Семь!");
                        break;
                    case 8:
                        Console.WriteLine("Восемь!");
                        break;
                    case 9:
                        Console.WriteLine("Девять!");
                        break;
                    default: // если было введено больше одной цифры, то переходим сюда.
                        Console.WriteLine("Получай обратно! " + n);
                        break;
                }
            }
            catch // произошла ошибка. Продолжение следует...
            {
                Console.WriteLine("Outta my way son! DOOR STUCK! I BEG YOU! We're dead.");
            }
            Console.ReadKey(); // check the results.
        }
    }
}
