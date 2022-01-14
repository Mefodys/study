using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson39_
{
    class Program
    {
        static void Foo()
        {
            int[] a = new int[10];
        }
        static void Main(string[] args)
        {
            Foo(); //после работы метода, как только осуществится выход из его контекста,
                   //на стеке данные пропадут, а в куче данные останутся. сборщик мусора потом уберется.


            int[] b = new int[5];

            b = null;

            Console.WriteLine(b[0]); // System.NullReferenceException: 'Object reference not set to an instance of an object.'
                                     // b was null.
        }
    }
}
