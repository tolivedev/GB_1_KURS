using System;
using Lessons._02_Lesson;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Greetings();

            Console.SetWindowSize(150, 30);
            try
            {
                do
                {

                    //NOTE: !Слишком не угорал по проверкам, поэтому, вероятно, где-то может быть неожиданное поведение!

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"
                    1.  Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
                    2.  Запросить у пользователя порядковый номер текущего месяца и вывести его название.
                    3.  Определить, является ли введённое пользователем число чётным.
                    4.  Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и 
                        схематично нарисуйте его в консоли, 
                        только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) 
                        подставляйте переменные, которые были заранее заготовлены до вывода на консоль.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nВыберите вариант задания");
                    char switcher = Console.ReadLine().ToCharArray()[0];

                    switch (switcher)
                    {
                        case '1': { new task02().TempAverage(); break; }
                        case '2': { new task02().SelectMonth(); break; }
                        case '3': { new task02().ShowOddNumb(); break; }
                        case '4': { new task02().PrintBill(); break; }

                        default:
                            {
                                Console.WriteLine("Введён неверный символ. Ввыберите один из '1,2,3,4' ");
                                break;
                            }
                    }


                }
                while (true);

            }
            catch (Exception arg)
            {
                Console.WriteLine("Возникло следующее: {0}", arg.Message);
            }
            Console.ReadKey();


        }
    }
}
