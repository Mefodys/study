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
            /*            
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

                        Console.WriteLine("***");

            */
            int firstDigit;

            while (true)
            {

                try
                {
                    Console.Clear();
                    Console.WriteLine("Enter the first digit: ");
                    firstDigit = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    //throw;
                    Console.WriteLine("Input string was not in a correct format. Press Enter");
                    Console.ReadLine();
                    continue;
                }

                while (true)
                {
                    Console.WriteLine(firstDigit);
                }
            }
            

        }
    }
}
