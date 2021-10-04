using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_11_all
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 10; n++)
            {
                for (int m = 1; m <= 10; m++)
                {
                    for (int k = 1; k <= 10; k++)
                    {
                        if (n * n + m * m == k * k)
                        {
                            Console.WriteLine(n + "^2 + " + m + "^2 = " + k + "^2");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}