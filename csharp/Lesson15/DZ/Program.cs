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
                Console.Clear();

                double cifra1;
                double cifra2;
                try
                {
                    Console.WriteLine("vvedite pervuiu cifru ");
                    cifra1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("vvedite vtoruiu cifru ");
                    cifra2 = double.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("convertation error");
                    Console.ReadLine();
                    continue;

                    //throw;
                }

                Console.WriteLine("vvedite operaciu (+ - * /): ");
                string oper = Console.ReadLine();

                switch (oper)
                {
                    case "+":
                        Console.WriteLine(cifra1 + cifra2);
                        break;
                    case "-":
                        Console.WriteLine(cifra1 - cifra2);
                        break;
                    case "*":
                         Console.WriteLine(cifra1 * cifra2);
                         break;
                    case "/":
                         if (cifra2 == 0)
                         {
                            Console.WriteLine("cifra2 ravna 0. na 0 delit nelzya.");
                            break;
                         }
                        else
                        {
                            Console.WriteLine(cifra1 / cifra2);
                            break;
                        }
                    default:
                        Console.WriteLine(cifra1 + cifra2);
                        Console.WriteLine(cifra1 - cifra2);
                        Console.WriteLine(cifra1 * cifra2);
                        Console.WriteLine(cifra1 / cifra2);
                        break;

                }



                //calculator using if else
                Console.WriteLine("vvedite pervuiu cifru ");
                double cifra3 = double.Parse(Console.ReadLine());

                Console.WriteLine("vvedite vtoruiu cifru ");
                double cifra4 = double.Parse(Console.ReadLine());

                Console.WriteLine("vvedite operaciu (+ - * /): ");
                string opera = Console.ReadLine();

                if (opera == "+")
                {
                    Console.WriteLine(cifra3 + cifra4);
                }
                else if (opera == "-")
                {
                    Console.WriteLine(cifra3 - cifra4);
                }
                else if (opera == "*")
                {
                    Console.WriteLine(cifra3 * cifra4);
                }
                else if (opera == "/")
                {
                    if (cifra3 == 0)
                    {
                        Console.WriteLine("cifra2 ravna 0. na 0 delit nelzya.");
                    }
                    else
                    {
                        Console.WriteLine(cifra3 / cifra4);
                     
                    }
                }
                else
                {
                    Console.WriteLine(cifra3 + cifra4);
                    Console.WriteLine(cifra3 - cifra4);
                    Console.WriteLine(cifra3 * cifra4);
                    Console.WriteLine(cifra3 / cifra4);
                    Console.ReadLine();
                }
                Console.WriteLine("press Enter");
                Console.ReadLine();

            }
        }
    }
}
