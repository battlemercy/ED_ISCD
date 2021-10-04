using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_5_while
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Произошла ошибка = переходим
            {   // к следующему блоку кода 'catch'.
                Console.WriteLine("Введите целое положительное число, кроме нуля: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int count = 0; // счётчик чётных.
                if (n > 0)
                {
                    while (n > 0)
                    {
                        if (n % 2 == 0)
                        {
                            count++;
                            n = n / 10;
                        }
                        else
                        {
                            n = n / 10;
                        }
                    }
                    Console.WriteLine("Количество чётных цифр: " + count);
                }
                else
                {
                    Console.WriteLine("я тебе по хорошему, ты мне по плохому...");
                }
            }
            catch
            {
                Console.WriteLine("Когда человек начинает считать себя поумневшим, он перестает умнеть.");
            }
            Console.ReadKey(); // check the results.
        }
    }
}
