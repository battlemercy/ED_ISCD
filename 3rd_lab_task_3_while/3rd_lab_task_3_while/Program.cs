using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_3_while
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Произошла ошибка = 
            {   // переходим к следующему блоку кода 'catch'.
                Console.WriteLine("Введите положительное целое число, которое больше 9: ");
                int n = Convert.ToInt32(Console.ReadLine()); // заносим число.
                if (n > 9)  // проверяем, можно ли его изменить.
                { // да, можно, то...
                    int d = 1; // создаём переменную, отвечающую за разряды...
                    // числа(десятки, сотни, тысячи и прочее).
                    while (n / (d * 10) > 0) // делаем так, пока не кончатся...
                    { // разряды числа.
                        d = d * 10; // добавляем разряд, т.е. умножаем на 10.
                    }
                    n = n % 10 * d + n % d / 10 * 10 + n / d; // строим новое число:
                    // последнее и первое числа меняем местами.
                    Console.WriteLine("Новое число: " + n);
                } // показываем пользователю новое число.
                else
                {
                    Console.WriteLine("Я ТЕБЯ ПОПРОСИЛ!");
                }
            }
            catch // попалась ошибка!
            {
                Console.WriteLine("Я ХОЧУ ПРАВДЫ!");
            }
            Console.ReadKey(); // check the results.
        }
    }
}
