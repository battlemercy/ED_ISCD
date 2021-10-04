using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turn_of_ferz
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
                int a = 0, b = 0;
                if ((numberstolba1 > 0 && numberstolba1 < 9) && (numberstolba2 < 9 && numberstolba2 > 0) && (numberstroki1 < 9 && numberstroki1 > 0) && (numberstroki2 < 9 && numberstroki2 > 0))
                {
                    if (numberstolba1 == numberstolba2 && numberstroki1 != numberstroki2)
                    {
                        Console.WriteLine("YES.");
                    }
                    else if (numberstroki1 == numberstroki2 && numberstolba1 != numberstolba2)
                    {
                        Console.WriteLine("YES.");
                    }
                    else if ((numberstolba1 + numberstroki1) % 2 == 0)
                    {
                        a++;
                    }
                    else if ((numberstolba2 + numberstroki2) % 2 == 0)
                    {
                        b++;
                    }
                    else if (a == b)
                    {
                        Console.WriteLine("YES.");
                    }
                    else
                    {
                        Console.WriteLine("NO.");
                    }
                }
                else
                {
                    Console.WriteLine("Ферзь не может туда сходить. NO.");
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
