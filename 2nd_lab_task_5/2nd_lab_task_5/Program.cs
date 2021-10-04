using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try // проверяем следующий блок кода на ошибки. Выполняем, если не возникла ошибка.
            {
                Console.WriteLine("Введите натуральное число 'n', которое меньше тысячи: "); // user enter n.
                int n = Convert.ToInt32(Console.ReadLine()); // натуральные числа - целые, поэтому int.
                int count = 0; // считает количество цифр в числе.
                if (n > 0 && n < 1000) // диапазон чисел [1; 999]
                {
                    if (n < 1000) // поiхали
                    {
                        n = n / 10; // делим целочисленно на разряды число.
                        count++; // прибавляем к счётчику.
                        if (n < 100 && n != 0) // обязательно, чтобы n не был равен нулю, иначе счётчик будет постоянно равен трём!
                        {
                            n = n / 10;
                            count++;
                            if (n < 10 && n != 0)
                            {
                                count++;
                            }
                        }
                    }
                    Console.WriteLine("Количество цифр в числе: " + count); // сам результат.
                }
                else
                {
                    Console.WriteLine("Число n не может быть равен нулю, и не больше тысячи, и оно целое!");
                }
            }
            catch // произошла ошибка. Продолжаем с этого блока кода.
            {
                Console.WriteLine("ЦИФРЫЫЫ!!!");
            }
            Console.ReadKey(); // check the results.
        }
    }
}
