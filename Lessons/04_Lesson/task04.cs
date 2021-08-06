using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._04_Lesson
{

    class task04
    {

        public task04()
        {
            Console.WriteLine(@"
                Укажите число расчетов фибоначчи. 
                Внимание!
                Проверок на ввод нет, необходимо вводить только положительные числа");

            CalcFibon(Convert.ToInt32(Console.ReadLine()));


        }
 

        private void CalcFibon(int icount)
        {
            Func<int, int> fib = null;
            fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;

            Console.WriteLine("Расчет фибоначчи: " + fib.Invoke(icount));
        }

    }
}
