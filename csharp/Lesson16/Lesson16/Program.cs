using System;

namespace Lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            // do while
            // for each

            //Console.WriteLine("DO ACTION");
            //Console.WriteLine("DO ACTION");

            Console.WriteLine("***");
            Console.WriteLine("Enter limit");
            uint limit = uint.Parse(Console.ReadLine());
            int count = 0;

            while (count < limit)
            {
                count++;
                Console.WriteLine("DO ACTION in while loop" + count);
                //Console.WriteLine(count);
            }

        }
    }
}
