using System;

namespace Example1
{
    class Program
    {

        //генерация массива.
        static int[,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();
            var results = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    results[i, j] = random.Next(100);
                }

            }
            return results;        
        }


        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 10;
            var myArray = GetRandomArray(rows, columns);

            //вывод массива в консоль
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
