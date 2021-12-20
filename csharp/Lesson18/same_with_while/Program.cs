using System;

namespace same_with_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit");
            int limit = int.Parse(Console.ReadLine());
            int start = 1;

            while (start <= limit)
            {
                Console.WriteLine("Hello World from WHILE! " + start);
                start++;

            }
        }
    }
}
