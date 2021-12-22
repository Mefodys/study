using System;

//вложенные циклы - один цикл вложен в другой цикл.
// можно вкладыать разные циклы друг в друга, например for в while.
namespace Lesson22
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("cycle 1, iteration " + i);
                for (int j = 1; j <= 5 ; j++)
                {
                    Console.WriteLine("\tcycle 2, iteration " + j);
                    for (int k = 1; k <= 2; k++)
                    {
                        Console.WriteLine("\t\tcycle 3, iteration " + k);

                    }
                }
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
