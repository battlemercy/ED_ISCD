using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_8_all
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int lose = 0, sum = 0;
                Console.WriteLine("Введите натуральное положительное число 'n': ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите натуральное положительное число 'm': ");
                int m = Convert.ToInt32(Console.ReadLine());
                if (n > 0 && m > 0)
                {
                    Console.WriteLine("Натуральные числа, квадрат суммы цифр которых равен " + m + " : ");
                    for (int i = 1; i < n; i++)
                    {
                        lose = i; // натуральное число, которое мы делим поразрядно
                        sum = 0; // сумма
                        while (lose > 0)
                        {
                            sum = sum + (lose % 10); // прибавляем остатки(разряды)
                            lose = lose / 10; // делим натуральное число на разряд
                        }
                        if (sum * sum == m) // сравниваем
                        {
                            Console.WriteLine(i); // пишем ответ
                        }
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
