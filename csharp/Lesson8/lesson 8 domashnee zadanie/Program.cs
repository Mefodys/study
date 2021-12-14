using System;

namespace lesson_8_domashnee_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            bool newvar1 = true;
            bool newvar2 = false;
            
            Console.WriteLine(newvar1);
            Console.WriteLine(newvar2);

            string a = Console.ReadLine();
            Console.WriteLine("holla hey " + a + "!!!");
            */


            //Console.WriteLine("Hello World!");


            double firstValue, secondValue;
           
            Console.WriteLine("Enter first number");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;
            Console.WriteLine("result = " + result);


            //***********************



        }
    }
}
