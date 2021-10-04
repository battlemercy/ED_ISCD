using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_lab
{
    class Program
    {
        static void Main(string[] args)
        {
             // переменная, содержащая в себе возраст пользователя.
            Console.WriteLine("Enter your (nick)name, please: "); // выводит данное предложение.
            string name = Console.ReadLine(); // переменная, содержащая в себе имя пользователя.
            Console.WriteLine("Enter your age, please: "); // выводит данное предложение.
            try // Следующий блок кода проверяется на наличие ошибок. Этот блок выполняется, пока не возникнет исключение/ошибка или пока он не будет успешно завершён.
            {
                int age = Convert.ToInt32(Console.ReadLine()); //  Переменная, содержащая в себе возраст пользователя. Меняет значение переменной, если пользователь ввёл положительное значение.
                // Convert.ToInt32 - преобразует заданное значение в 32-битовое целое число со знаком.
                if (name != "" && age >= 0) // проверяем ̶ч̶е̶с̶т̶н̶о̶с̶т̶ь̶ ̶и̶ ̶т̶у̶п̶о̶с̶т̶ь̶ ̶п̶о̶л̶ь̶з̶о̶в̶а̶т̶е̶л̶я: содержат ли переменные какие-либо значения? 
                {
                    Console.WriteLine("Hello, " + name + ". You are " + age + " y.o.!"); // если да, то приветствует пользователя и говорит, сколько ему лет.
                }
                else
                {
                    Console.WriteLine("You are trapped in a Joker trap!"); // если нет, то он попал в ловушку Джокера.
                }
            }
            catch // Обрабатывает исключение/ошибку и продолжает с этого куска кода. Если ошибка не произошла, то этот кусок кода не воспроизводится / не активируется.
            {
                Console.WriteLine("You are trapped in a Joker trap!"); // если произошла, то он попал в ловушку Джокера.
            }
            Console.ReadKey(); // ну надо же увидеть результаты!
        }
    }
}
