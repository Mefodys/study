using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ref
//передача аргументов по ссылке

namespace Lesson43
{
    class Program
    {
        static void Foo(int a)
        {
            a = -5;
        }

        static void FooWithRef(ref int a)
        {
            a = 3;
        }

        static void FooWithRefAdditionalExpample(ref int a, ref int b, ref int c, ref int d)
        {
            a = 5;
            b = 10;
            c = 15;
        }
        
        static void Main(string[] args)
        {
            int a = 2;
            Foo(a); // т.к. переменная a - значимый тип, данные передаются по значению. копируются. то есть посл
            //отработки метода Foo, контекст перейдет из Foo обратно в Main. поэтому изменения переменной a в методе Foo, не будут сохранены. 
            //переменная а после работы метода, будет равна 2.


            FooWithRef(ref a); // использование ref. передача значимого типа теперь происходит по ссылке, а не по значению. в описании метода, тоже нужно указывать ref.
            //данные не будут копироваться. после того, как метод в которые передали переменную по ссылке отработает, то переменная сохранит свое состояние (изменение в методе).
            //переменная будет равна 3 после работы метода Foo1. мы получили поведение, как у ссылочных типов.

            //зачем это нужно, если можно использовать return. мы можем поменять несколько переменных одним методом.
            FooWithRefAdditionalExpample(ref a); //нашушение принципов SOLID. Single Responsibility.





            Console.ReadLine();
        }
    }
}
