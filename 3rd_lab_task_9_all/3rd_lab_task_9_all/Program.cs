using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_9_all
{
    class Program
    {
        static int SumDel(int x) // sumdel возвращает сумму делителей
        { // функция
            int res = 0; // сумма делителей
            for (int i = 1; i <= x / 2; i++) // прогоняем до половины, чтобы ускорить процесс
            {   // т.е. вторая половина не даст никаких делителей
                if (x % i == 0)
                { // если делится полностью
                    res = res + i; // то прибавляем в сумму делителей
                }
            }
            return res; // возвращаем сумму
        }
        static void Main(string[] args)
        {
            try
            {
                int p = 0; // переменная, чтобы программа не выходила за рамки цикла, а также это - сумма делителей первого числа
                Console.WriteLine("Введите натуральное положительное число 'n', которое является началом диапазона: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите натуральное положительное число 'm', которое является концом диапазона: ");
                int m = Convert.ToInt32(Console.ReadLine());
                if (n > 0 && m > 0)
                {
                    Console.WriteLine("Пары дружественных чисел в диапазоне от n до m: ");
                    p = n;
                    while (p >= n && p < m) // проверяем, выходит ли за пределы
                    { // если нет, то
                        if (SumDel(SumDel(p)) == p && p != SumDel(p))
                        { // сравнивает сумму делителя первого числа с суммой делителя второго числа
                            Console.WriteLine(p + " и " + SumDel(p));
                        } // и выводим число и его сумму делителей.
                        p++;
                    }
                }
                else
                {
                    Console.WriteLine("...");
                }
            }
            catch
            {
                Console.WriteLine("...");
            }
            Console.ReadKey();
        }
    }
}
