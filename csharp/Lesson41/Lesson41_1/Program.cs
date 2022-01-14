using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson41_1
{
    class Program
    {
        static int [] GetArray()
        {
           // int[] arr = new int [11];
            int[] arr = null;
            return arr;
        }
        static void Main(string[] args)
        {

            int[] arr = GetArray();

            arr ??= new int[0];
        }
    }
}
