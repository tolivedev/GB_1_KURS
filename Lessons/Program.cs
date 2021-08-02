using System;
using Lessons._03_Lesson;


namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(150, 30);
            try
            {
                do
                {

                    //NOTE: !Слишком не угорал по проверкам, поэтому, вероятно, где-то может быть неожиданное поведение!

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"
                    1. Написать программу, выводящую элементы двухмерного массива по диагонали.
                    2. Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: 
                    первый элемент хранит имя контакта, второй — номер телефона/e-mail.
                    3. Написать программу, выводящую введенную пользователем строку в обратном порядке(olleH вместо Hello).");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nВыберите вариант задания");
                    char switcher = Console.ReadLine().ToCharArray()[0];

                    switch (switcher)
                    {
                        case '1':
                            {
                                Console.WriteLine("Введите размерности массива разделяя нажатием клавиши Ввод");
                                int dim1 = Convert.ToInt32(Console.ReadLine());
                                int dim2 = Convert.ToInt32(Console.ReadLine());
                                new task03().OutputArrayDiag(dim1, dim2); break;
                            }
                        case '2': { new task03().PhoneDictionary(); break; }
                        case '3': { new task03().InvertString(); break; }

                        default:
                            {
                                Console.WriteLine("Введён неверный символ. Ввыберите один из '1,2,3' ");
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

