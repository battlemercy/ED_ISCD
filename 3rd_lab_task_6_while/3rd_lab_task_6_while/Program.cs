using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_6_while
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Произошла ошибка = переходим к
            {   // следующему блоку кода 'catch'.
                Console.WriteLine("Введите целое положительное число, кроме нуля: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int max = 0, ostatok = 0;
                if (n > 0)
                {
                    while (n > 0)
                    { // ostatok - последнее число
                        ostatok = n % 10;
                        if (max < ostatok)
                        {
                            max = ostatok;
                        }
                        n = n / 10;
                    }
                    Console.WriteLine("Самое большая цифра числа: " + max);
                }
                else
                {
                    Console.WriteLine("я же попросил.");
                }
            }
            catch
            {
                Console.WriteLine("От знаний еще никто не умирал, но рисковать не стоит.");
            }
            Console.ReadKey(); // check the results.    
        }
    }
}
