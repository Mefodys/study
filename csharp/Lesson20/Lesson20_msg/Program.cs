using System;

namespace Lesson20_msg
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 999; i++)
            {
                string msg = Console.ReadLine();
                if (msg == "exit")
                {
                    Console.WriteLine("bye");
                    System.Threading.Thread.Sleep(500);
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
