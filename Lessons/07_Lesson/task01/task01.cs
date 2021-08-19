using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._07_Lesson.task01
{
    class task01
    {
        /// <summary>
        /// Во вложении лежит исправленный il код и его скомпилированная версия. Честно говоря, с адресами вызовов мне пока не понятно. 
        /// Ассемблерный язык для меня незнаком.
        /// </summary>
        void Mai_n(string[] args)
        {
            string secret = "secret";
            Console.WriteLine("Enter password:");
            string input = Console.ReadLine();
            if (input == secret)
            {
                Console.WriteLine("Welcome!");
            }
            Console.ReadLine();
        }
    }
}
