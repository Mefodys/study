using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 111, 10, 4, 99, 49, 66, 77, 4, 42, 5 };

            int result1 = myArray.Min();
            int result2 = myArray.Max();

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.WriteLine(myArray.Sum());

            Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum()); // вывод суммы четных элементов
                                                                     // метод where позволяет поместить внутрь себя условие для поска.
                                                                     // метод принимает в себя делегат условие для поиска.
                                                                     // мы здесь выше указали там лямбда выражение.


            //найти уникальные элементы:
            int [] result3 = myArray.Distinct().ToArray();
            Console.WriteLine(result3);

            int[] result4 = myArray.OrderBy(i => i).ToArray();

            Console.WriteLine(myArray.ToString());

            Array.Sort(myArray);
            //Console.WriteLine(myArray);

            int result5 = Array.Find(myArray, i => i < 70);
            Console.WriteLine(result5);

            int result6 = Array.FindLast(myArray, i => i < 70);
            Console.WriteLine(result6);

            int [] result7 = Array.FindAll(myArray, i => i < 70);

            Array.Reverse(myArray);

            Console.ReadLine();
        }
    }
}
