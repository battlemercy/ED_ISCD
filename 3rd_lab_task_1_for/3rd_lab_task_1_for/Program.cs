using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_1_for
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите натуральное положительное число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int s = 0, a = 1; // s - сумма, a - слагаемые.
                for (int i = 1; i <= n; i++)
                { // Григорий заводит счётчик.
                    a = 1; // слагаемые начинаются с единицы и увеличиваются каждый раз на 2.
                    Console.Write(i + "^2 = " + a); // выписываем первое слагаемое.
                    for (int b = 1; b < i; b++) 
                    { // счётчик количества слагаемых, чтобы не вписать лишние.
                        a = a + 2; // делаем разницу между слагаемыми, равным двум, по условию.
                        Console.Write(" + " + a); // выписываем следующие слагаемые с плюсами.
                    }
                    s = s + a; // прибавляем к сумме.
                    Console.Write(" = " + s); // выводим сумму в конце.
                    Console.WriteLine(" "); // чтобы все расчёты не выводились в одну строку.
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
