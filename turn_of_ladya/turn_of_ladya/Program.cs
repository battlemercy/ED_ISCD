using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turn_of_ladya
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
                if ((numberstolba1 > 0 && numberstolba1 < 9) && (numberstolba2 < 9 && numberstolba2 > 0) && (numberstroki1 < 9 && numberstroki1 > 0) && (numberstroki2 < 9 && numberstroki2 > 0))
                {
                    if (numberstolba1 == numberstolba2)
                    {
                        Console.WriteLine("Ладья может туда попасть. YES.");
                    }
                    else if (numberstroki1 == numberstroki2)
                    {
                        Console.WriteLine("Ладья может туда попасть. YES.");
                    }
                    else
                    {
                        Console.WriteLine("Ладья не может туда попасть. NO.");
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
