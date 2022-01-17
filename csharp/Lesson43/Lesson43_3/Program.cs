using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson43_3
{
    class Program
    {
        //static ref int Foo (int[] numbers)
        //{
            
        //}
        static void Main(string[] args)
        {
            int[] arr = { 2, 6, 1 };

            //int b = arr[0];  // в этом случае, переменная b не связана с массиваом. она отдельная. её изменение не затрагивает массив
            
            ref int b = ref arr[0]; // при использовании ref, можно менять элемент в массиве по ссылке.

            b = -5; //в массиве вместо 2 появится 5.
           
        }
    }
}
