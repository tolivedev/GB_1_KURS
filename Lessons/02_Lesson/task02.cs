using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lessons._02_Lesson
{
    /// <summary>
    /// 1.  Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
    /// 2.  Запросить у пользователя порядковый номер текущего месяца и вывести его название.
    /// 3.  Определить, является ли введённое пользователем число чётным.
    /// 4.  Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
    ///     только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) 
    ///     подставляйте переменные, которые были заранее заготовлены до вывода на консоль.
    /// </summary>
    class task02
    {
        public task02()
        {

        }

        public void Meth()
        {
            int[] arr = new int[6];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = i;
            }

        }

        internal void SelectMonth()
        {

            //обернуть ввод через tryparse и неинициализируемый out параметр
            int parseNum;//, m;
            string numMonth;

            do
            {
                Console.WriteLine("Введите номер месяца ");
                numMonth = Console.ReadLine();
                if (int.TryParse(numMonth, out parseNum) && (parseNum > 0 && parseNum < 13))
                {
                    break;
                }
                Console.WriteLine("\nВведенное значение не из диапазаона 1-12!");

            }
            while (true);

            Console.WriteLine("Месяц " + (EnumMonth)parseNum);
        }

        internal void TempAverage()
        {
            Console.WriteLine("Введите минимальную температуру");
            string minTemp = Console.ReadLine();
            Console.WriteLine("Введите максимальную температуру");
            string maxTemp = Console.ReadLine();
            int a = string.IsNullOrEmpty(minTemp) ? 0 : Convert.ToInt32(minTemp);
            int b = string.IsNullOrEmpty(maxTemp) ? 0 : Convert.ToInt32(maxTemp);

            if (a != 0 || b != 0)
            {
                Console.WriteLine("Средняя температура за сутки: {0}", (a + b) / 2);
            }
            else
            {
                Console.WriteLine("Введенные значения недопустимы");
            }
        }


        // 3

        internal void ShowOddNumb()
        {
            Console.WriteLine("Введите число ");
            string val = Console.ReadLine();

            int numb = string.IsNullOrEmpty(val) ? 0 : Convert.ToInt32(val);

            if (numb % 2 != 0)
            {
                Console.WriteLine("\nЧисло {0} нечетное!", numb);
            }
        }

        internal void PrintBill()
        {
            CultureInfo myCIintl = new CultureInfo("en-US", false);
            double quantity = 1.00;
            DateTime dateTime = new DateTime(2021, 07, 28, 10, 00, 00);
            string employee = "Иванов И И";

            Console.WriteLine(@"
Стол № Ст10
Официант {0}
Дата {1:D}    Время {2:T}
Гостей 2
 
Американо                           {3}
РОМ                                 {3}
Латте 0,4                           {3}
Fanta                               {3}
Латте 0,4                           {3}
Чай Зелёный                         {3}
Трипл сек                           {3}
", employee, dateTime,dateTime, quantity.ToString("f2", myCIintl));
        }

    }

}

