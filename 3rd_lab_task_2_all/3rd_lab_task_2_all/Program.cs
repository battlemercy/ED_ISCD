using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_2_all
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char kek = '+';
                int cola = 0, mother = 0, daddy = 0;
                Console.WriteLine("Введите положительное целое число 'n', больше нуля: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    for (int i = 1; i < n; i++)
                    {
                        cola = 0; // определяет кол-во плюсов
                        mother = 0; // счётчик плюсов(т.е. сколько уже записал плюсов)
                        for (daddy = 1; daddy < n; daddy++)
                        {
                            if (i % daddy == 0)
                            {
                                cola++;
                            }
                        }
                        Console.Write(i); // само число.
                        while (mother < cola)
                        {
                            Console.Write(kek);
                            mother++;
                        }
                        Console.WriteLine(" ");
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
