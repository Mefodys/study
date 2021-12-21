using System;

namespace Lesson19
{
    class Program
    {

        /*
         *  for особенности
            несколько переменных
            for в обратном порядке
            несколько условий.
         * 
         */
        static void Main(string[] args)
        {

            /*
            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(i);
            }
            */


            /*
                        for (;;) //цикл выполняется бесконечно, т.к. нет условий.
                        {
                            Console.WriteLine("written from for");
                            System.Threading.Thread.Sleep(500);
                            break;
                        }
                        Console.WriteLine("written from for");

                        int i = 0;
                        for (; i < 3; i++)
                        {
                            Console.WriteLine(i + " from first for");
                        }

                        for (; i < 5; i++)
                        {
                            Console.WriteLine(i + " from second for");

                        }
            */

            /*
                        for (int i = 0; i < 5;)
                        {
                            Console.WriteLine("for_3: " + i);
                            i++;
                        }

                        for (int i = 0; i < 5;)
                        {
                            i++;
                            Console.WriteLine("for_4: " + i);
                        }

                        for (int i = 0, j = 5 ; i < 10 && j < 12; i++,j+=2)
                        {
                            Console.WriteLine("for_5 i: " + i);
                            Console.WriteLine("for_5 j: " + j);

                        }

            */

            /*
                        for (int i = int.Parse(Console.ReadLine()); i >= 0; i--)
                        {
                            Console.WriteLine("for_6 " + i);
                        }
            */
            for (int i = 0, j = 5; i < 5; i++,j--) //i инкрементимс 0 до 5. j декрементим с 5 до 0. достаточное условие i<5/.
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);

            }

        }
    }
}
