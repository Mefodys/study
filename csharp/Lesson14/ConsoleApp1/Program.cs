using System;

namespace ConsoleApp1
{
    class Program
    {

        public static bool GetTemperature()
        {
            return true;
        }

        public static bool GetCoolingStatus()
        {
            return true;
        }

        static void Main(string[] args)
        {
            
        if (GetTemperature() | GetCoolingStatus())
        {
            Console.WriteLine("CPU can be damaged!!!");
        }
        
        
        
        }
    }
}
