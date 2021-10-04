using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Появилась ошибка в следующем блоке кода =
            {   // переходим к следующему блоку кода 'catch'.
                Console.WriteLine("Введите натуральное число 'n', которое меньше тысячи: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int n1 = 0, n2 = 0, n3 = 0, nmax = 0, nmin = 0, nmid = 0;
                if (n > 0 && n < 1000)
                {
                    if (n > 9 && n < 100)
                    {
                        n1 = n / 10;
                        n2 = n % 10;
                        if (n1 > n2)
                        {
                            nmax = n1;
                            nmin = n2;
                        }
                        else
                        {
                            nmin = n1;
                            nmax = n2;
                        }
                        Console.WriteLine("Цифры в порядке возрастания: " + nmin + nmax);
                    }
                    else if (n > 99)
                    {
                        n1 = n / 100;
                        n2 = n % 100 / 10;
                        n3 = n % 10;
                        if (n1 >= n2)
                        {
                            nmax = n1;
                        }
                        else
                        {
                            nmax = n2;
                        }
                        if (n3 >= nmax)
                        {
                            nmax = n3;
                        }
                        if (n1 <= n2)
                        {
                            nmin = n1;
                        }
                        if (n2 <= n1)
                        {
                            nmin = n2;
                        }
                        if (n3 <= n2 && n3 <= n1)
                        {
                            nmin = n3;
                        }
                        if ((n1 >= n2 && n1 <= n3) || (n1 >= n3 && n1 <= n2))
                        {
                            nmid = n1;
                        }
                        if ((n2 >= n1 && n2 <= n3) || (n2 >= n3 && n2 <= n1))
                        {
                            nmid = n2;
                        }
                        if ((n3 >= n1 && n3 <= n2) || (n3 >= n2 && n3 <= n1))
                        {
                            nmid = n3;
                        }
                        Console.WriteLine("Цифры в порядке возрастания: " + nmin + nmid + nmax);
                    }
                    else
                    {
                        Console.WriteLine("Число однозначное: " + n);
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели число, которое не соответствует условию!");
                }
            }
            catch
            {
                Console.WriteLine("ВЫ НЕ ГОТОВЫ!!!");
            }
            Console.ReadKey();
        }
    }
}