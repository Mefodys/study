using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,] 
            {
                {3, 5, 6},
                {7, 4, 3},
                {9, 4, 1}
            };


            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
