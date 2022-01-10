using System;

namespace DZ3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Random rnd = new Random();
                int rand1 = rnd.Next(1, 100);  
                int rand2 = rnd.Next(1, 100);

                Console.SetCursorPosition(rand1, rand2);
                Console.Write("*");
                //Console.WriteLine();
                //Console.g
            }
        }
    }
}
