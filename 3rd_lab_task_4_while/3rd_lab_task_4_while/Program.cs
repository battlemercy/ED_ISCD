using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_4_while
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Произошла ошибка =
            {   // переходим к следующему блоку кода 'catch'.
                Console.WriteLine("Введите положительное число, больше нуля: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    if (n > 9)
                    {
                        int novoe = 0, posl = 0;
                        while (n > 0)
                        {
                            posl = n % 10; // записываем последнюю цифру.
                            novoe = novoe * 10 + posl; // строим новое.
                            n = n / 10; // сокращаем старое.
                        }
                        Console.WriteLine("Обратное число: " + novoe);
                    }
                    else
                    {
                        Console.WriteLine("Число меньше десяти, поэтому оно не изменилось: " + n);
                    }
                }
                else
                {
                    Console.WriteLine("я хочу положительное число!");
                }
            }
            catch // пiймав!
            {
                Console.WriteLine("Стасян, чё по матеше?");
            }
            Console.ReadKey(); // check the results.
        }
    }
}
