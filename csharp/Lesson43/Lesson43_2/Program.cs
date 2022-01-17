using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson43_2
{
    class MyClass //ссылочный тип. передается по ссылке. 
    {
        public int a;
        public double b;
        public float c;
    }
    class Program
    {
        static void Foo(MyClass myClass)
        {
            myClass.a = 5;
        }

        static void Bar(int[] arr) // передача массива в метод, изменение 0го элемента. присвоемние ссыле null. данные в изначальном массиве будут изменены.
        {
            arr[0] = 10;
            arr = null; // не затронет изначальный массив.
            arr = new int[10]; //это изменение также не затронет изначальный массив. если же в метод мы получи ref ссылку, то на изначальном массиве изменения отразятся.

        }

        static void Mar(ref int[] arr) // передача массива по ссылке. null будет присовен в изначальный массив(который мередвали из main в метод)
        {
            arr = null; // присвоение null массиву по ссылке.


        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Foo(myClass); // после работы метода, данные в классе(переменная а) останутся измененными. т.к. класс ссылочный тип.


            int[] myArray = { 1, 4, 5};
            Bar(myArray); //после работы метода, в случае массива, первый элемент останется измененным, после выхода из контекста метода. 

            Mar(ref myArray); // в случае передачи массива по ссылке ref, и в методе присваиваения null, то массив вне контекста метода также будет изменен. а именно будет равен null.
        }
    }
}
