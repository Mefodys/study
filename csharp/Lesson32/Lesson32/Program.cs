using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson32
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] myArray = new int[2, 3];
            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {

                    //заполнение массива случайными числами
                    //myArray[i, j] = random.Next(100);   

                    //заполнение массива с клавиатуры
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            //вывод массива
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
