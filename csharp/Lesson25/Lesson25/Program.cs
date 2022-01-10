using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[5]; //массив нулей типа  int 

            int[] myArray2 = new int[5] {100, 1, 2, 3, 4 }; //инициализируем массив значениями

            int[] myArray3 = new int[] { 100, 1, 2, 3, 10, 50 }; //инициализируем массив значениями,не указываем количество элементов

            int[] myArray4 = new [] { 100, 1, 2, 3, 10, 50 }; //инициализируем массив значениями, не испльзуем указание типа после new

            int[] myArray5 = { 100, 1, 2, 3, 4 }; //инициализируем массив значениями, упрощенно.


            int[] myArray6 = Enumerable.Repeat(5, 10).ToArray();

            int[] myArray7 = Enumerable.Range(4, 5).ToArray();



            Console.WriteLine("Hell0");
            Console.ReadLine();
        }
    }
}
