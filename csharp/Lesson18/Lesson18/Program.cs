using System;

namespace Lesson18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit");
            int limit = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine("Hello World from FOR! " + i);

            }

/*            while (true)
            {
                Console.WriteLine("Hello World from WHILE!");
            }
*/

        }
    }
}
