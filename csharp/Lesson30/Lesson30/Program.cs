using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = {1,3,1,3,4 }; // одномерный массив (для примера)
            
            int[,] myArray2 = new int[2,3]; // двумерный массив. по умолчанию инициализирвются нулями, т.к. имеет тип int.

            myArray2[1, 2] = 4; // присваеваем данные в элемент массива.

            myArray2[5, 5] = 100; // получим ошибку, т.к. вышли за пределы массива.


            int[,] myArray3 = new int[2, 2]
            {
                {3,4},
                {5,6}
            };


            
           
            Console.ReadLine();
        }
    }
}
