using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 3, 2, 55 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

         
            Console.ReadLine();
        }
    }
}

//задания
// 1 заполнить массив с клавиатуры
// 2 вывести массив в обртном поярдке
// 3 найти сумму четных чисел в массиве
// 4 найти наименьшее число в массиве.