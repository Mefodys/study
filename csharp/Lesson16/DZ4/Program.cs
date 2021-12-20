using System;

namespace DZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("input first number");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("input second number");
                int secondNumber = int.Parse(Console.ReadLine());

                //Console.WriteLine(firstNumber);
                //Console.WriteLine(secondNumber);

                uint countEven = 0;
                uint countOdd = 0;

                               
                    if (firstNumber < secondNumber)
                    {
                        Console.WriteLine("firstNumber < secondNumber");
                        while (firstNumber <= secondNumber)
                        {
                            if (firstNumber % 2 == 0)
                            {
                                countEven++;
                            }
                            else
                            {
                                countOdd++;
                            }

                            firstNumber++;
                        }
                    }
                    else if (firstNumber > secondNumber)
                    {
                        Console.WriteLine("firstNumber > secondNumber. firstNumber shoud be less than secondNumber\n");
                        continue;
                    }
                    else if (firstNumber == secondNumber)
                    {
                        Console.WriteLine("firstNumber == secondNumber. firstNumber shoud be less than secondNumber\n");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Unknown error");
                        break;
                    }

                
                Console.WriteLine("countEven: " + countEven);
                Console.WriteLine("countOdd: " + countOdd);
                Console.WriteLine("\n");


            }




        }
    }
}
