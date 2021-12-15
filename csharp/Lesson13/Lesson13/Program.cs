using System;

/*
 if - else


if (true)
{
    code1;
}
else
{
    code2;
}
 */


namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isInfected = true;

            if (isInfected)
            {
                Console.WriteLine("you are infected!");
            }
            else
            {
                Console.WriteLine("you are not infected!");

            }
        }
    }
}
