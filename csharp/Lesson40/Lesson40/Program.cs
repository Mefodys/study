using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson40
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "test";
            Console.WriteLine(str);

            string str2 = null;
            Console.WriteLine(str2); //ничего не выведется. но нам нужно обработать этот момент.

            if (str2 == null)
            {
                Console.WriteLine("no data");
            }
            else
            {
                Console.WriteLine(str2);
            }

            string str3 = null;
            //string str3 = "test";

            Console.WriteLine(str3 ?? "no data (with ??)");

            Console.ReadLine();
        }
    }
}
