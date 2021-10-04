using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Произошла ошибка = 
            {   // переходит к следующему блоку кода 'catch'.
                Console.WriteLine("Введите натуральное положительное число 'k': ");
                int k = Convert.ToInt32(Console.ReadLine()); // число последовательности.
                Console.WriteLine("Что программа должна вывести подряд?");
                string wishusera = Console.ReadLine(); // выводим то, что нужно пользователю.
                if (wishusera == "Натуральные числа")
                { // wish usera = желание пользователя
                    for (int i = 1; i <= k; i++)
                    {
                        Console.Write(i); // выписываем в строчку натуральные числа.
                    }
                }
                else if (wishusera == "Квадраты натуральных чисел")
                {
                    for (int i = 1; i <= k; i++)
                    {
                        Console.Write(Math.Pow(i, 2)); // выписываем квадраты натур. чисел
                    } // в строку.
                }
                else if (wishusera == "Числа Фибоначчи")
                {
                    int a = 1, b = 1, c = 0;
                    for (int i = 1; i <= k; i++)
                    {
                        c = a; // n
                        a = b; // n-2
                        b = b + c; // n-1
                        Console.Write(c);
                    }
                }
                else
                {
                    Console.WriteLine("Программа не поняла Вас.");
                }
            }
            catch
            {
                Console.WriteLine("Программа не поняла Вас.");
            }
            Console.ReadKey();
        }
    }
}
