using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ35_3
{
    class Program
    {
       static int [] CreateRandomArray(uint lenght, int minValue, int maxValue)
        {
            int[] myArray = new int[lenght];
            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue,maxValue);
            }

            return myArray;
        }

        static void Main(string[] args)
        {
            int[] resut = CreateRandomArray(5, 1, 10);

            Console.ReadLine();
        }
    }
}
