using System;

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {

            //calculator using switch
            Console.WriteLine("vvedite pervuiu cifru ");
            int chifra1 = int.Parse(Console.ReadLine());

            Console.WriteLine("vvedite vtoruiu cifru ");
            int chifra2 = int.Parse(Console.ReadLine());

            Console.WriteLine("vvedite operaciu (+ - * /): ");
            string oper = Console.ReadLine();

            switch (oper)
            {
                case "+":
                    Console.WriteLine(chifra1 + chifra2);
                    break;
                case "-":
                    Console.WriteLine(chifra1 - chifra2);
                    break;
                case "*":
                    Console.WriteLine(chifra1 * chifra2);
                    break;
                case "/":
                    Console.WriteLine(chifra1 / chifra2);
                    break;

            }



            //calculator using if else
            Console.WriteLine("vvedite pervuiu cifru ");
            int chifra3 = int.Parse(Console.ReadLine());

            Console.WriteLine("vvedite vtoruiu cifru ");
            int chifra4 = int.Parse(Console.ReadLine());

            Console.WriteLine("vvedite operaciu (+ - * /): ");
            string opera = Console.ReadLine();

            if (opera == "+")
            {
                Console.WriteLine(chifra3 + chifra4);
            }
            else if (opera == "-")
            {
                Console.WriteLine(chifra3 - chifra4);
            }
            else if (opera == "*")
            {
                Console.WriteLine(chifra3 * chifra4);
            }
            else if (opera == "/")
            {
                Console.WriteLine(chifra3 / chifra4);
            }
            else
            {
                Console.WriteLine(chifra3 + chifra4);
                Console.WriteLine(chifra3 - chifra4);
                Console.WriteLine(chifra3 * chifra4);
                Console.WriteLine(chifra3 / chifra4);

            }
        }
    }
}
