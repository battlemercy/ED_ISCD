using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            try // обработчик ошибок/исключений. Появилась ошибка в следующем блоке кода = переходим к следующему
            {   // блоку кода 'catch'.
                Console.WriteLine("Введите символ: ");
                char symbol = Convert.ToChar(Console.ReadLine()); // в char записывается в переменную только один символ.
                if (symbol >= '0' && symbol <= '9')
                { // сначала проверяем: цифра ли?
                    Console.WriteLine("Это цифра!");
                }
                else if (symbol >= 'A' && symbol <= 'Z')
                { // теперь буквы.
                    Console.WriteLine("Это английская большая буква!");
                }
                else if (symbol >= 'a' && symbol <= 'z')
                {
                    Console.WriteLine("Это английская маленькая буква!");
                }
                else if (symbol >= 'а' && symbol <= 'я')
                {
                    Console.WriteLine("Это русская маленькая буква!");
                }
                else if (symbol >= 'А' && symbol <= 'Я')
                {
                    Console.WriteLine("Это русская большая буква!");
                }
                else if (symbol == '%' || symbol == '/' || symbol == '*' || symbol == '+' || symbol == '-')
                { // теперь знаки операции.
                    Console.WriteLine("Это знак операции!");
                }
                else
                { // иначе, это другие символы.
                    Console.WriteLine("Это другие символы!");
                }
            }
            catch
            { // если пользователь ввёл несколько символов, то он попадает в dungeon.
                Console.WriteLine("BOY NEXT DOOR");
            }
            Console.ReadKey(); // check the results.
        }
    }
}
