using System;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
//            int i = 0;
  //          int j = 0;

            for (int i = 0; i < 5; i++)
             {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                
                }
                Console.Write("\n"); //or writline can be used Console.WriteLine();
            }
        }
    }
}
