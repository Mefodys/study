using System;
/*
 * Операторы
 * Арифметические операции с числами.
 *
 */
namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double a = 2;
            int b = 5;
            double result = a / b;
            */

            /*
            int a = 2;
            int b = 5;
            double result = (double) a / b; // использование (double) в скобаках здесь это приведение типов. сохранять результат тоже нужно в переменную типа double.
            */

            Console.WriteLine("*****");

            /*
                        int a = 11;
                        int b = 3;
                        int c = 4;

                        int result = a % b; // 11 делить на 3, получатеся 3, и в остатке 2

                        int sum = a + b + c;
                        int r = c + 5;

                        Console.WriteLine(result);
                        Console.WriteLine(sum);
            */


            /*           //напишите программу, вычислающую среднее арифметическое двух чисел
                       Console.WriteLine("Enter first number");
                       string a = Console.ReadLine();

                       Console.WriteLine("Enter second number");
                       string b = Console.ReadLine();

                       int converted_a = Convert.ToInt32(a);
                       int converted_b = Convert.ToInt32(b);

                       int result = (converted_a + converted_b) / 2;

                       Console.WriteLine("Srednee arifmeticheskoe ravno " + result);
           */




            /*            //введите три числа и выведите на экран значение суммы и произведения этих чисел
                        Console.WriteLine("Enter first number");
                        string a = Console.ReadLine();

                        Console.WriteLine("Enter second number");
                        string b = Console.ReadLine();

                        Console.WriteLine("Enter third number");
                        string c = Console.ReadLine();

                        int converted_a = Convert.ToInt32(a);
                        int converted_b = Convert.ToInt32(b);
                        int converted_c = Convert.ToInt32(c);

                        int summatreh = converted_a + converted_b + converted_c;
                        int multiplication = converted_a * converted_b * converted_c;


                        Console.WriteLine("Summa treh chisel ravna " + summatreh);
                        Console.WriteLine("Proizvedenie treh chisle ravno " + multiplication);
            */




            //напишите простой конвертер валют (без возмомжности динамического выбора валюты пользователем).
            //Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.

            double kurs_dollara = 74.31;
            
            Console.WriteLine("Klurs dollara raven " + kurs_dollara + " rubley");
            
            Console.WriteLine("Skolko rubley hotite pomeniat'?");
            string rubl = Console.ReadLine();
                       
            int converted_rubl = Convert.ToInt32(rubl);

            double result = converted_rubl / kurs_dollara;

            Console.WriteLine("Poluchite " + result + " dollarov");







        }
    }
}
