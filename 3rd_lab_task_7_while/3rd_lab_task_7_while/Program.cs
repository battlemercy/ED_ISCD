using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_7_while
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Произошла ошибка = 
            {   // переходим к следующему блоку кода 'catch'.
                Console.WriteLine("Введите целое положительное число, не равное нулю: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int ostatok = 0, sum = 0;
                if (n > 0)
                {
                    while (n > 0)
                    {
                        ostatok = n % 10; // последняя цифра
                        if (ostatok > 5)
                        {
                            sum = sum + ostatok;
                        }
                        n = n / 10;
                    }
                    Console.WriteLine("Сумма цифр, больших пяти: " + sum);
                }
                else
                {
                    Console.WriteLine("...");
                }
            }
            catch
            {
                Console.WriteLine("Деньги приходят и уходят, и уходят, и уходят...");
            }
            Console.ReadKey();
        }
    }
}
