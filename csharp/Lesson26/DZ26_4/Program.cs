using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4 найти наименьшее число в массиве.
namespace DZ26_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 5, 6, 2,-100, 2, 1, -10 };
            int minvalue = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minvalue)
                {
                    minvalue = myArray[i];
                }

            }
            Console.WriteLine(minvalue);
            Console.ReadLine();
        }
    }
}
