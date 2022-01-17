using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.  написать метод Resize изменяющий количество элементов  массива
//(метод должен иметь возможность увеличить или уменьшить количетво элементов массива)

namespace Lesson43_DZ1
{
    class Program
    {
        static void Resize(int[] arr, uint count)
        {
            var tempArr = new int[arr.Length + count];

            arr.CopyTo(tempArr, 0);
            

        }
        static void Main(string[] args)
        {
            int[] myArray = { 10, 5, 3 };

            Resize(myArray, 2);
        }
    }
}
