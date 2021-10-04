using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_12_all
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Произошла ошибка = переходим к следующему блоку кода 'catch'.
            {
                Console.WriteLine("Введите целое положительное число, которое вы хотите возвести в третью степень и больше нуля: ");
                int n = Convert.ToInt32(Console.ReadLine()); // заносим введённое в эту переменную.
                if (n > 0)
                {
                    int s = 0, a = 0; // s - первое слагаемое/сумма, a - слагаемые.
                    for (int i = 1; i <= n; i++)
                    { // Григорий заводит счётчик.
                        s = i * (i - 1) + 1; // считаем первое слагаемое.
                        a = s; // заносим считанное слагаемое в переменную.
                        Console.Write(i + "^3 = " + s); // выписываем первое слагаемое.
                        while (s < i * i * i) // пока сумма меньше числа в третьей степени, то...
                        {
                            a = a + 2; // добавляем слагаемому двоечку, т.к. разница между числами = 2.
                            Console.Write(" + " + a); // выписываем следующие слагаемые с плюсами.
                            s = s + a; // прибавляем к сумме.
                        }
                        Console.Write(" = " + s); // выводим сумму в конце.
                        Console.WriteLine(" "); // чтобы все расчёты не выводились в одну строку.
                    }
                }
                else
                {
                    Console.WriteLine("Программа не поняла Вас.");
                }
            }
            catch // ошибка попалась!
            {
                Console.WriteLine("Программа не поняла Вас.");
            }
            Console.ReadKey(); // смотрим результаты.
        }
    }
}
