using System;

namespace Lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Hello World! from DO WHILE");
                

            } while (false);

            int count = 5;
            
            //*****************************
            while (count < 5)
            {
                count++;
                Console.WriteLine("Hello World! FROM WHILE1");
            }

            int b = 0;
            do
            {
                b++;
                Console.WriteLine("Hello World! FROM WHILE2");

            } while (b < 3);

        }
    }
}
