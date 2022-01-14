using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson40_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "test";
            str = null;

//            string result = str ?? "";
            string result = str ?? string.Empty;


            //Console.WriteLine("numbers of symbols in the string is " + str.Length);
            Console.WriteLine("numbers of symbols in the string is " + result.Length);

            Console.ReadLine();
        }
    }
}
