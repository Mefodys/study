using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson35
{
    class Program
    {

        static int Sum(int x, int y)
        {
            int result = x + y;
            
            return result;
        }


        static void PrintResult(int result)
        {
            Console.WriteLine("result is " + result);
        }
        static void Main(string[] args)
        {

            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a,b);
            PrintResult(c);

            //Console.WriteLine(c);
            Console.WriteLine("===========");


            Console.ReadLine();
        }
    }
}
