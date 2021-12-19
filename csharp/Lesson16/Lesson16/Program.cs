using System;

namespace Lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            // do while
            // for each

            //Console.WriteLine("DO ACTION");
            //Console.WriteLine("DO ACTION");
            /*            
                        Console.WriteLine("***");
                        Console.WriteLine("Enter limit");
                        uint limit = uint.Parse(Console.ReadLine());
                        int count = 0;

                        while (count < limit)
                        {
                            count++;
                            Console.WriteLine("DO ACTION in while loop" + count);
                            //Console.WriteLine(count);
                        }

                        Console.WriteLine("***");

            */
            int firstDigit;
            int secondDigit;
            string action;

            while (true)
            {
                Console.Clear();

                while (true)
                {
                    try
                    {
                        //Console.Clear();
                        Console.WriteLine("Enter the first digit: ");
                        firstDigit = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        //throw;
                        Console.WriteLine("Input string was not in a correct format. Press Enter");
                        Console.ReadLine();
                        continue;
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter the second digit: ");
                        secondDigit = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        //throw;
                        Console.WriteLine("Input string was not in a correct format. Press Enter");
                        Console.ReadLine();
                        continue;
                    }
                }

                uint counter = 0;
                while (counter <= 3)
                {
                    
                    try
                    {
                        Console.WriteLine("Enter the action ('+' or '-' or '*' or '/') : ");
                        action = Console.ReadLine();
                        switch (action)
                        {
                            case "+":
                                Console.Write(firstDigit + " + " + secondDigit + " = ");
                                Console.Write(firstDigit + secondDigit + "\n");
                                break;
                            case "-":
                                Console.Write(firstDigit + " - " + secondDigit + " = ");
                                Console.Write(firstDigit - secondDigit + "\n");
                                break;
                            case "*":
                                Console.Write(firstDigit + " * " + secondDigit + " = ");
                                Console.Write(firstDigit * secondDigit + "\n");
                                break;
                            case "/":
                                Console.Write(firstDigit + " / " + secondDigit + " = ");
                                Console.Write(firstDigit / secondDigit + "\n");
                                break;
                            default:
                                Console.WriteLine(" You entered not '+' or '-' or '*' or '/'! ");
                                continue;
                        }
                        counter++;
                    }
                    catch (Exception)
                    {
                        //throw;
                        Console.WriteLine("Input string was not in a correct format. Press Enter");
                        Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine("Press Enter to restart...");

                    Console.ReadLine();
                    break;
                }
                

            }








        }
    }
}
