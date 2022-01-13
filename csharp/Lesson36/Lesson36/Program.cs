using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson36
{
    class Program
    {
        /// <summary>
        /// returns a + b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum (int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Sum(double a, double b)
        {
            return a + b;

        }

        static void Main(string[] args)
        {
            int resutl1 = Sum(1, 2);
            int result2 = Sum(1, 2, 3);
            double resutl3 = Sum(1.5, 2.4);

        }
    }
}
