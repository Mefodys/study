using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1 заполнить массив с клавиатуры
namespace DZ26_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array: ");
            int arraySize = int.Parse(Console.ReadLine());

            int[] myArray = new int[arraySize];


            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter "+  i + " element of the array: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("The array is: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i]);
                Console.Write(" ");

            }
            Console.ReadLine();

        }
    }
}
