using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_10_all
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int mama = 0, pomogi = 0, kill = 0; // kill должен быть равен нулю,
                // иначе у нас всегда новое число будет начинаться с единицы.
                Console.WriteLine("Введите натуральное положительное число 'n': ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    for (int i = 0; i < 10; i++)
                    { // счётчик сравнивает полученное число с номером захода
                        mama = n; // присваиваем натур. число
                        while (mama > 0)
                        {
                            pomogi = mama % 10; // кладём в переменную последнюю цифру.
                            if (pomogi == i) // если посл. цифра равна счётчику
                            { // то
                                kill = kill * 10 + pomogi; // составляем число
                                mama = mama / 10; // убираем последнюю цифру.
                            }
                            else
                            {
                                mama = mama / 10;
                            }
                        }
                    }
                    Console.WriteLine("Готовое число: " + kill);
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
