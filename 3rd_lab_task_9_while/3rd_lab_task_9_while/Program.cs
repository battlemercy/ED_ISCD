using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_9_while
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 0, da = 0, n1 = 0;
                while (i < 10) // счётчик чисел, чтобы мы не вводили больше десяти чисел.
                {
                    Console.WriteLine("Введите целое число: ");
                    int n = Convert.ToInt32(Console.ReadLine()); // вводим числа.
                    if (n > n1) // сравниваем с предыдущим, чтобы узнать - есть ли возрастание.
                    { // если да, то...
                        i++; // увеличиваем счётчик чисел.
                        da++; // прибавляем в переменную единицу.
                        n1 = n; // присваиваем предыдущее значение в переменную 'n1'.
                    }
                    else
                    { // иначе...
                        i++; // увеличиваем счётчик чисел.
                    }
                }
                if (da == 10)
                {  // проверяем, всегда ли числа возрастали.
                    Console.WriteLine("Последовательность чисел - возрастающая.");
                }
                else
                {
                    Console.WriteLine("Последовательность чисел - не возрастающая.");
                }
            }
            catch
            {
                Console.WriteLine("За себя и за Сашку!!!");
            }
            Console.ReadKey();
        }
    }
}
