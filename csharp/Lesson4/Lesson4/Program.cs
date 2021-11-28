using System;

/*
 переменные
объявление
инициализация - когда данные пормещатся в перменную.

//тип_данных имя_переменной;
 
 */
namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 15;
            b = 10;
            c = a + b;
            //Console.WriteLine(a);
            Console.WriteLine("a = " + a); 
            Console.WriteLine("b = " + b);
            Console.WriteLine("a + b = " + c);

            //плохо называть переменные так, как ниже
            bool variable = false;
            bool variable2 = true;
            Console.WriteLine(variable);
            Console.WriteLine(variable2);

            char f = '#'; 
            char g = '*';
            string fda = "asdfjkasdf;ljk";
            Console.WriteLine(f + g + fda);
            Console.WriteLine(f);

        


        }
    }
}
