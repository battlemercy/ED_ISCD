using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_2_while
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. В случае ошибки переходим
            {   // к следующему блоку 'catch'.
                Console.WriteLine("Введите положительное число 'n': ");
                int n = Convert.ToInt32(Console.ReadLine());
                int count = 0; // счётчик, чтобы не приписывал единицы
                if (n >= 0)    // больше одного раза.
                { // проверяем, положительное ли число.
                    while (count == 0)
                    { // приписываем единицы один раз
                        Console.WriteLine("1" + n + "1");
                        count++; 
                    }
                }
                else
                {
                    Console.WriteLine("Отрицательные числа вводить нельзя!");
                }
            }
            catch // СЖЕЧЬ ЕГО!
            {
                Console.WriteLine("...");
            }
            Console.ReadKey(); // эх, сейчас бы сОчка))
        }
    }
}
