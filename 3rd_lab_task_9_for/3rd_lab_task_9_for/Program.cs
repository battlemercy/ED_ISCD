using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_9_for
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sum = 0;
                Console.WriteLine("Введите положительное целое значение начала промежутка 'A': ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите положительное целое значение конца промежутка 'B': ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a >= 0 && b >= 0)
                {
                    for (int i = a; a < b; a++)
                    {
                        if (a % 4 == 0)
                        {
                            sum = sum + a;
                        }
                    }
                    Console.WriteLine("Сумма целых положительных чисел в данном промежутке равна: " + sum);
                }
                else
                {
                    Console.WriteLine("Вы ввели отрицательное значение.");
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
