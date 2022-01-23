using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.  написать метод Resize изменяющий количество элементов  массива
//(метод должен иметь возможность увеличить или уменьшить количетво элементов массива)
// увеличение сделал, нужно сделать уменьшение.

namespace Lesson43_DZ1
{
    class Program
    {
        static void Resize <T>(ref T[] arr, uint newSize) //generic usage (PLUS ref usage).
        {
            var newArr = new T[newSize];

            for (int i = 0; i < arr.Length && i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;

        }
        static void Main(string[] args)
        {
            int[] myArray = { 10, 5, 3 };
            string[] strArray = { "test", "hello", "world" };

            Resize(ref myArray, 2);
            Resize(ref strArray, 2);
        }
    }
}
