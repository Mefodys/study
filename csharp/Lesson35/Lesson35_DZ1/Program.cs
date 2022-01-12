using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//написать метод, который выводит на экран строку.
//символы из которых стостит строка и их количество вводит пользователь.

namespace Lesson35_DZ1
{
    class Program
    {
        static void countofSymbols(int count, string symbl)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i + " " + symbl);
            }

        }

        static void Main(string[] args)
        {
            int countOfSimbols = int.Parse(Console.ReadLine());

            string asymbol = Console.ReadLine();

            Console.WriteLine();

            countofSymbols(countOfSimbols, asymbol);

            //Console.WriteLine(countOfSimbols);
            //Console.WriteLine(asymbol);

            Console.ReadLine();

        }
    }
}
