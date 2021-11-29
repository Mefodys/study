using System;
using System.Globalization;

/*
 * конвертация строки
 * класс Convert 
 */
namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();

            string str1 = "5";
            string str2 = "2";
            Console.WriteLine(str1 + str2 + "concatination 5 and 2"); //выполнится конкатенация двух строк. то есть получится 52, а не 7

            int convertedstr1 = Convert.ToInt32(str1);
            int convertedstr2 = Convert.ToInt32(str2);
            Console.WriteLine(convertedstr1 + convertedstr2);

            //int converted3 = Convert.ToInt32("sdf"); // ошибка. нельзя конвертировать строку из букв в цифру
            //Console.WriteLine(converted3);


            Console.WriteLine("Enter first number ");
            string str3 = Console.ReadLine();

            Console.WriteLine("Enter second number ");
            string str4 = Console.ReadLine();

            int convertedstr3 = Convert.ToInt32(str3);
            int convertedstr4 = Convert.ToInt32(str4);

            int sum = convertedstr3 + convertedstr4;
            Console.WriteLine("Summ of " + convertedstr3 + " and " + convertedstr4 + " is " + sum);


            string str5 = "1,9"; // если использовать разделилиь запятую, без использования класса NumberFormatInfo, то результат будет 19, что неверно.
            
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ",",
            };
            
            double convertedstr5 = Convert.ToDouble(str5, numberFormatInfo);
            Console.WriteLine(convertedstr5);


        }
    }
}
