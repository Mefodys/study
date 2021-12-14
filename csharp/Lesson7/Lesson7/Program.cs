using System;
using System.Globalization;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "7";
            int a = int.Parse(str);


            /*
            string str2 = "5,6";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ",",
            };
            
            double b = double.Parse(str2, numberFormatInfo);
            */

            //string str3 = "5.9";
            string str3 = null;
            try
            {
                double c = double.Parse(str3);
                Console.WriteLine(c);
             }
            catch (Exception)
            {
                Console.WriteLine("Convertation error");
                Console.WriteLine("******************");
                //Console.WriteLine(Exception);
            }

            string str4 = "2 h";
            int aa;

            bool result = int.TryParse(str4, out aa); //return bool
            if (result)
            {
                Console.WriteLine("Success " + aa);
            }
            else
            {
                Console.WriteLine("Unsuccessful convert");
            }
        }
    }
}
