using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._05_Lesson
{
    class lesson05
    {

        public lesson05()
        {
            Console.SetWindowSize(150, 30);
            try
            {
                do
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"
1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
4. Создать класс 'Сотрудник' с полями: ФИО, должность, email, телефон, зарплата, возраст");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nВыберите вариант задания");
                    char switcher = Console.ReadLine().ToCharArray()[0];

                    switch (switcher)
                    {
                        case '1': { new task01(); break; }
                        case '2': { new task02(); break; }
                        case '3': { new task03(); break; }
                        case '4': { new task04(); break; }

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
                Console.WriteLine("Упс, Возникло следующее: {0}", arg.Message);
            }

        }
    }
}
