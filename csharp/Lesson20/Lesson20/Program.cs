using System;

namespace Lesson20
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 999; i++)
            {
                
                Console.WriteLine(i);
                if (i==10)
                {
                    break;
                }
            }
        }
    }
}
