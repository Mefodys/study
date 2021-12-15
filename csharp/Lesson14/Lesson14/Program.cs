using System;

/*
 Logic operations
&& сокращенное И
|| сокращенное ИЛИ
& И
| ИЛИ
! НЕ (унарный)
 
 
 */
namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * bool isInfected = false;

            if (!isInfected)
            {
                Console.WriteLine("You are healthy!");
            }
            else
            {
                Console.WriteLine("You are infected!");
            }
            */

            bool isHighTemerature = true;

            int fanSpeed = 300;
            //bool hasNoColling = false;
            bool hasNoColling = fanSpeed <=0;


            //          if (isHighTemerature && hasNoColling) //то есть, если первая переменная и вторая true, то исполняем кусок кода. Если одна из переменных false - не исполняем кусок кода.
            if (isHighTemerature || hasNoColling) //исполяем код, если один из параметров true. ИЛИ

            {
                    Console.WriteLine("CPU can be damaged!");
            }


        }
    }
}
