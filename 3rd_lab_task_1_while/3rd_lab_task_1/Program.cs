using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. В случае
            {   // ошибки переходим к следующему блоку 'catch'.
                Console.WriteLine("Введите натуральное число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                while (n > 0)
                {
                    sum = sum + n % 10; // прибавляет последнюю цифру.
                    n = n / 10; // убирает последнюю цифру.
                }
                Console.WriteLine("Сумма цифр числа равна: " + sum);
            }
            catch // ПОЙМАТЬ ЕГО!
            {
                Console.WriteLine("EXCUSE ME?!");
            }
            Console.ReadKey(); // check the results.
        }
    }
}