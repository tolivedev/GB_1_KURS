using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._06_Lesson
{
    class lesson06
    {

        public lesson06()
        {
            Console.SetWindowSize(150, 30);
            try
            {
                do
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"
1. Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
2. Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4,
при подаче массива другого размера необходимо бросить исключение MyArraySizeException.
Далее метод должен пройтись по всем элементам массива, преобразовать в int, и просуммировать.
Если в каком-то элементе массива преобразование не удалось
(например, в ячейке лежит символ или текст вместо числа), должно быть брошено исключение MyArrayDataException, 
с детализацией в какой именно ячейке лежат неверные данные.
В методе main() вызвать полученный метод, обработать возможные исключения MySizeArrayException и MyArrayDataException, и вывести результат расчета.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nВыберите вариант задания");
                    char switcher = Console.ReadLine().ToCharArray()[0];

                    switch (switcher)
                    {
                        case '1': { new task01(); break; }
                        case '2': { new task02(); break; }
                   

                        default:
                            {
                                Console.WriteLine("Введён неверный символ. Ввыберите один из '1,2' ");
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
