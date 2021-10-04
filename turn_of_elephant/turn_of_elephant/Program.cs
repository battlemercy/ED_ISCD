using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turn_of_elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите номер столбца первой клетки от 1 до 8: ");
                int numberstolba1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер строки первой клетки от 1 до 8: ");
                int numberstroki1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер столбца второй клетки от 1 до 8: ");
                int numberstolba2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер строки второй клетки от 1 до 8: ");
                int numberstroki2 = Convert.ToInt32(Console.ReadLine());
                int a = 0, b = 0; // переменные для сравнения.
                if ((numberstolba1 > 0 && numberstolba1 < 9) && (numberstolba2 < 9 && numberstolba2 > 0) && (numberstroki1 < 9 && numberstroki1 > 0) && (numberstroki2 < 9 && numberstroki2 > 0))
                {
                    if ((numberstolba1 + numberstroki1) % 2 == 0)
                    { // если клетка делится без остатка, то клетка чёрного цвета двадцатого века.
                        Console.WriteLine("Первая клетка - чёрная.");
                        a++;
                    } // спасибо паПаша!
                    else
                    {
                        Console.WriteLine("Первая клетка - белая.");
                        a += 2;
                    }
                    if ((numberstolba2 + numberstroki2) % 2 == 0)
                    {
                        Console.WriteLine("Вторая клетка - чёрная.");
                        b++;
                    }
                    else
                    {
                        Console.WriteLine("Вторая клетка - белая.");
                        b += 2;
                    }
                    if (a == b)
                    {
                        Console.WriteLine("Слон может попасть туда, т.к. клетки одинакового цвета. YES.");
                    } // клетки - котлетки
                    else
                    {
                        Console.WriteLine("Слон не может попасть туда, т.к. клетки разных цветов. NO.");
                    }
                }
                else
                {
                    Console.WriteLine("Программа не поняла Вас.");
                }
            }
            catch
            {
                Console.WriteLine("Программа не поняла Вас.");
            }
            Console.ReadKey();
        }
    }
}
