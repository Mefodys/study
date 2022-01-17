using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ref передача аргументов по ссылке
namespace Lesson43_1
{
    struct MyStruct  //значимый тип, копируется на стеке. таким образом, если не использоваться ref в методе, то мы копируем на стек всю структуру. это затратно.
    {
        public int a;
        public double b;
        public float c;
    }
    class Program
    {
        static void Foo(ref MyStruct myStruct) //получаем ссылку вместо всего объекта. 
        {
            myStruct.a = -5;
        }
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct();

            Foo(ref myStruct); //вызывавем метод для объекта по ссылке. после работы метода, в стуктуре останется изменение.
            // если мы не будем использовать ref при изменении структуры, то получим классическое поведение значимого типа
            // после выхода из контекста метода, на стеке пропадут переменные метода, и по возващению в main, мы не получим изменение переменных в стркутуре.
        }

    }
}
