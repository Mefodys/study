using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson38_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[2] { 3, 4 };
            int[] b;

            b = a; //на стеке будут две ссылки на два массива, которые ссылаются на одни и те же данные в куче.
            // при подобной операции для значимого типа, на стеке будет 2 переменные.

            Console.ReadLine();

        }
    }
}
