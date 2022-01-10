using System;

namespace Lesson24
{
    class Program
    {
        static void Main()
        {
            int[] myArray; //массив создан, но не ссыллается никуда в опертивную память (в управляемую кучу).
            myArray = new int[5]; //выделяем место в оперативной памяти под наш массив. на 5 элементов при помощи оператора new.
                                  
            myArray[0] = 3;
            myArray[1] = 10;
            //myArray[10] = 5;



            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray[1]);

            Console.WriteLine();
            
            Console.WriteLine(myArray);
            Console.WriteLine(myArray.Length);
            
            Console.WriteLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }



            //Console.WriteLine("Hello World!");
        }
    }
}
