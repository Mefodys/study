using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson39_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a; //в стеке объект есть, а ссылки нет.
            a = new int[10]; //теперь в куче выделяется память.  как только это происходит, NULL меняется на ссылку на реальные данные.
            int b; //

            a = null; // разрываем связь между данными в куче и стеком. в с++ была бы утечка памяти, но в с#, потом память в куче почистить сборщик мусора
        }
    }
}
