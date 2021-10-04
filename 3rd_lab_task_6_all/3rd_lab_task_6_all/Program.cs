using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_6_all
{
    class Program
    {
        static void Main(string[] args)
        {
                int zombie = 0, zombie1 = 0, ilon = 0;
                for (int i = 1; i <= 10000; i++) // счётчик натуральных чисел.
                {
                    zombie = 0; // переменная, содержащая в себе сумму делителей.
                    for (int lose = 1; lose < i; lose++)
                    { // lose - счётчик для поиска делителя.
                        if (i % lose == 0)
                        {
                            zombie = zombie + lose; // сумма делителей.
                        }
                    }
                    if (zombie > zombie1) // проверяет новую сумму делителей со старой максимальной суммой делителей.
                    {
                        zombie1 = zombie;
                        ilon = i; // сюда записывается натуральное число, которое содержит максимальную сумму делителей.
                    }
                }
                Console.WriteLine("Натуральное число с максимальной суммой делителей: " + ilon);
                Console.ReadKey();
        }
    }
}
