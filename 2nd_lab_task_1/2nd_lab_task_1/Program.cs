using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0, x = 0; // программа позволяет вводить целые и дробные числа.
            Console.WriteLine("Введите число 'a': "); // просим пользователя ввести число 'b'.
            try // проверяем на ошибки. Если их не было, то код успешно выполняется.
            {
                a = Convert.ToSingle(Console.ReadLine()); // записываем число 'a'.
                Console.WriteLine("Введите число 'b': "); // просим пользователя ввести число 'b'.
                b = Convert.ToSingle(Console.ReadLine()); // записываем число 'b'.
                if (a != 0) // если число 'a' не равен нулю, то выполняем...
                {
                    x = (-b) / a; // это...
                    Console.WriteLine("X = " + x); // и это действия.
                }
                else if (a == 0 && b == 0) // иначе нас встречает ещё одно условие: если число 'a' равен нулю и число 'b' равен нулю.
                {
                    Console.WriteLine("Ответ: 0"); // думаю, тут объяснять не нужно?
                }
                else if (a == 0 && b != 0) // да когда эти условия кончатся??? (если число 'a' равен нулю и число 'b' не равен нулю)
                {
                    Console.WriteLine("Ответ: нет корней."); // тут я точно не буду объяснять...
                }
            }
            catch // если мы поймали маслину(ошибку), то продолжаем с этого куска кода.
            {
                Console.WriteLine("Ты снова написал дробное число через точку, или символ, или оставил поля пустыми!? =*( ");
            }
            Console.ReadKey(); // я понял то, что двойной slash даёт поспамить в коде :D
        }
    }
}