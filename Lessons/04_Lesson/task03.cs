using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._04_Lesson
{

    enum Seasons
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }

    class task03
    {
        public task03()
        {
            Init();
        }
        private void Init()
        {

            Console.WriteLine("Введите номер месяца:");
            try
            {
                int numMonth = AcceptInput();

                while (true)
                {
                    if (numMonth <= 12 && numMonth >= 1)
                    {
                        NumberMonth(numMonth);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: введите число от 1 до 12");
                        numMonth = AcceptInput();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }

        private int AcceptInput()
        {
            string s = Console.ReadLine();
            if (s == null)
            {
                string local1 = s;
                return 0;
            }
            return int.Parse(s);
        }
        private void RetSns(Seasons winter)
        {
            switch (winter)
            {
                case Seasons.Winter:
                    Console.WriteLine("Зима");
                    break;

                case Seasons.Spring:
                    Console.WriteLine("Весна");
                    break;

                case Seasons.Summer:
                    Console.WriteLine("Лето");
                    break;

                case Seasons.Autumn:
                    Console.WriteLine("Осень");
                    break;

                default:
                    throw new ArgumentOutOfRangeException("winter", winter, null);
            }
        }


        private void NumberMonth(int number)
        {
            switch (number)
            {
                case 12:
                case 1:
                case 2:
                    RetSns(Seasons.Winter);
                    break;
                case 3:
                case 4:
                case 5:
                    RetSns(Seasons.Spring);
                    break;
                case 6:
                case 7:
                case 8:
                    RetSns(Seasons.Summer);
                    break;
                case 9:
                case 10:
                case 11:
                    RetSns(Seasons.Autumn);
                    break;
                default:
                    break;
            }

        }
    }
}
