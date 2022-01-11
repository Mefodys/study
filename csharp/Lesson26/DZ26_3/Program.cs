using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 3 найти сумму четных чисел в массиве
namespace DZ26_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 4, 6, 3, 3 };
            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result += myArray[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
