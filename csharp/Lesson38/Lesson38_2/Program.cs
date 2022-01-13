using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson38_2
{
    class Program
    {

        static void Foo (int a)
        {
            a = 5;
        }

        static void Bar(int[] arr)
        {
            arr[0] = 5;
        }
        static void Main(string[] args)
        {
            int a = 1;
            Foo(a);
            Console.WriteLine(a);

            int[] b = new int[1];
            b[0] = 1;
            Bar(b); //ссылочний тип, в методе в массиве переназначится элемент 0. после выхода из метода данные останутся измененными. при значимом типе, после работы метода стек очиститься и данные вне метода не будут изменены.
            
            Console.WriteLine(b[0]);

        }
    }
}
