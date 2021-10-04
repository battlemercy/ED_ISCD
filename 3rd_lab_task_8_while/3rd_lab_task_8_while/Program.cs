using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_8_while
{
    class Program
    {
        static void Main(string[] args)
        {
            try // произошла ошибка = переходим к следующему блоку кода 'catch'.
            {
                Console.WriteLine("Введите целое положительное число, не равное нулю: ");
                int n = Convert.ToInt32(Console.ReadLine()); // записываем введённое число.
                int posl = 0, count = 0; // posl - последнее число, count - счётчик.
                if (n > 0)
                {
                    Console.WriteLine("Введите цифру, которую нужно узнать на повторение: ");
                    int k = Convert.ToInt32(Console.ReadLine());
                    if (k >= 0 && k <= 9)
                    {
                        while (n > 0)
                        {
                            posl = n % 10; // находим последнюю цифру.
                            if (k == posl) // узнаём, повторяется ли она.
                            { // если да, то прибавляем к счётчику.
                                count++;
                            }
                            n = n / 10; // убираем последнюю цифру из числа.
                        }
                    }
                    Console.WriteLine("Эта цифра встречается " + count + " раз.");
                }
                else
                {
                    Console.WriteLine("Олды тут?");
                }
            }
            catch
            {
                Console.WriteLine("Олды тут?");
            }
            Console.ReadKey();
        }
    }
}
