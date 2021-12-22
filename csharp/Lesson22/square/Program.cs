using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite visotu pryamougolnika: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Vvedite shirinu pryamougolnika: ");
            int width = int.Parse(Console.ReadLine());


            for (int i = 0; i < height; i++)
            {
                for (int j = 0;  j < width; j++)
                {
                    Console.Write("#");

                }
                Console.WriteLine();
                //Console.Write("#");

            }
        }
    }
}
