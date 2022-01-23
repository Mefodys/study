using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// написать методы для добавления элемента в начало массива, в конец массива и по указанному индексу.

namespace Lesson43_DZ2
{
    class Program
    {
        static void AdditionAtStart(ref int[] myArray, int newValue)
        {
            int newArrayLength = myArray.Length + 1;
            int[] newArray = new int [newArrayLength];

            newArray[0] = newValue;

            for (int i = 1; i <= (myArray.Length); i++)
            {
                newArray[i] = myArray[i - 1];
            }
            myArray = newArray;

        }

        static void AdditionAtEnd(ref int [] myArray, int newValue)
        {
            int newArrayLength = myArray.Length + 1;
            int[] newArray = new int[newArrayLength];

            for (int i = 0; i < newArray.Length; i++)
            {

                if (i == newArrayLength-1)
                {
                    newArray[i] = newValue;
                }
                else
                {
                    newArray[i] = myArray[i];
                }

            }
            myArray = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 2, 5, 7, 55 };
            int newValue1 = 10;
            int newValue2 = 100;


            AdditionAtStart(ref myArray, newValue1);
            AdditionAtEnd(ref myArray, newValue2);
            AdditionAtStart(ref myArray, newValue1);
            AdditionAtEnd(ref myArray, newValue2);


        }
    }
}
