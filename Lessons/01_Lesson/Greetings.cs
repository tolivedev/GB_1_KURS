using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons
{
    class Greetings
    {
        public Greetings()
        {
            Console.WriteLine("Введите имя пользователя: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Привет, {userName}, сегодня {DateTime.Now}");
        }
    }
}
