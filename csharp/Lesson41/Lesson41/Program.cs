using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson41
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            //string result = str ?? string.Empty; //в str остается null, в result пустая строка "".
            string result = str ??= string.Empty; //в str также теперь содержится пустая строка "", в result пустая строка "".


            Console.WriteLine(result.Length);
            Console.WriteLine(str.Length); // в случае ??= мы можем работать далее с str.

        }
    }
}
