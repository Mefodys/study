using System;

namespace domashnee_zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VVedite chislo");
            string chislo;
            int converted_chislo;
            chislo = Console.ReadLine();

            bool result = int.TryParse(chislo, out converted_chislo); //return bool


            if (result)
            {
                if (converted_chislo % 2 == 0)
                {
                    Console.WriteLine("chetnoe chislo");
                }
                else
                {
                    Console.WriteLine("nechetnoe chislo");
                }
            }
            else
            {
                Console.WriteLine("Convertation error");
            }
        }
    }
}
