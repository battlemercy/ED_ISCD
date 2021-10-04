using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_3_all
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите положительное целое число 'n', больше нуля: ");
                int n = Convert.ToInt32(Console.ReadLine()); 
                if (n > 0) // ограничение, до какого числа нужно искать совершённые.
                {
                    for (int i = 1; i < n; i++)
                    {
                        int papa = 1; // делитель
                        int sum = 0;
                        while (papa < i)
                        {
                            if (i % papa == 0) // делится ли нацело.
                            {
                                sum = sum + papa;// если да, то суммируем.
                                papa++; // 
                            }
                            else
                            {
                                papa++;
                            }
                        }
                        if (sum == i)
                        {
                            Console.WriteLine("Число " + sum + " - совершённое!");
                        }
                    }
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
