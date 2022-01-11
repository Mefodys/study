using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2 вывести массив в обртном поярдке
namespace DZ26_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 9, 77, 3, 5, 1 };

            for (int i = myArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
