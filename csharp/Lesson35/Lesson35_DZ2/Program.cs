using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//написать метод для поиска индекса элемента массива (тип элементов в массиве int).
//метод должен вернуть индекс первого найденного элемента (если он будет найден).
namespace Lesson35_DZ2
{
    class Program
    {

        static int MyIndexMethod(int[] myArray, int searchvalue)
        {
            int myIndex = 0;
            //public bool noSuchNumber = 0;
        

            for (int i = 0; i < myArray.Length; i++)
            {
                if (searchvalue == myArray[i])
                {
                    myIndex = i;
                    break;
                }
                if (i == myArray.Length - 1)
                {
                    //noSuchNumber = 1;
                    return 999;
                }
            }
            return myIndex;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 4, 6, 1, 5, 2, 8, 3, 4, 7, 1, 9 };

            int searchvalue = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int result = MyIndexMethod(myArray, searchvalue);

            if (result == 999)
            {
                Console.WriteLine("no such number in the array");

            }
            else
            {
                Console.WriteLine(result);

            }

            Console.ReadLine();
        }
    }
}
