using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int a = 0;
            a++;
            Console.WriteLine(a++);
            Console.WriteLine(--a);
            Console.WriteLine(a);

            int b = 1;
            b = ++b * b; // унарная операция имеет приоритет. сначала будет выполнена операция инкремента,
                         // то есть b станет равна 2, затем будет выполнена операция умножения, то есть 2*2 
                         // результат 4.
            int c = 1;
            c = c++ * c; //в этом случае, сначала будет выполнено умножение, затем инкремент. результат 2.
        }
    }
}
