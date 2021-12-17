using System;

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {

            //calculator using switch
            while (true) 
            { 
                Console.WriteLine("vvedite pervuiu cifru ");
                double chifra1 = double.Parse(Console.ReadLine());

                Console.WriteLine("vvedite vtoruiu cifru ");
                double chifra2 = double.Parse(Console.ReadLine());

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
                         if (chifra2 == 0)
                         {
                            Console.WriteLine("cifra2 ravna 0. na 0 delit nelzya.");
                            break;
                         }
                        else
                        {
                            Console.WriteLine(chifra1 / chifra2);
                            break;
                        }
                    default:
                        Console.WriteLine(chifra1 + chifra2);
                        Console.WriteLine(chifra1 - chifra2);
                        Console.WriteLine(chifra1 * chifra2);
                        Console.WriteLine(chifra1 / chifra2);
                        break;

                }



                //calculator using if else
                Console.WriteLine("vvedite pervuiu cifru ");
                double chifra3 = double.Parse(Console.ReadLine());

                Console.WriteLine("vvedite vtoruiu cifru ");
                double chifra4 = double.Parse(Console.ReadLine());

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
                    if (chifra3 == 0)
                    {
                        Console.WriteLine("cifra2 ravna 0. na 0 delit nelzya.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(chifra3 / chifra4);
                     
                    }
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
}
