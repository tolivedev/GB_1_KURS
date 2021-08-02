using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._03_Lesson
{
    /// <summary>
    /// 1. Написать программу, выводящую элементы двухмерного массива по диагонали.
    /// 2. Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: 
    ///     первый элемент хранит имя контакта, второй — номер телефона/e-mail.
    /// 3. Написать программу, выводящую введенную пользователем строку в обратном порядке(olleH вместо Hello).
    /// 4. * «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
    /// </summary>
    class task03
    {


        public void InvertString()
        {
            Console.WriteLine("Введите слово, например Hello");
            string str = Console.ReadLine();
            char[] chArr = str.ToCharArray();
            Array.Reverse(chArr);
            string reverse = new string(chArr);
            Console.WriteLine(reverse);

            //Альтернативный подход

            Console.WriteLine("Альтернативный подход без Reverse");
            str = Console.ReadLine();
            chArr = str.ToCharArray();

            for (int i = chArr.Length-1; i >= 0; i--)
            {
                Console.Write(chArr[i]);
            }

        }
        private string[,] InitArrDict()
        {
            string[,] dict = new string[5, 2]
            {
                { "Андрей", "9551112233" },
                { "Иван", "9552112233" },
                { "Сергей", "9553112233" },
                { "Владимир", "9553112233" },
                { "Кирилл", "9554112233" }
            };

            return dict;
        }
        /// <summary>
        /// Правильней всего было бы реализовать данную задачу с помощью индексатора для класса, либо коллекцией Dictionary<>. 
        /// Пишу решение как того требует условие задания.
        /// </summary>
        public void PhoneDictionary()
        {
            string[,] dict = InitArrDict();

            for (int i = 0; i < dict.GetLength(0); i++)
            {
                for (int j = 0; j < dict.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0}".PadRight(20), dict[i, j]));
                }
                Console.WriteLine();
            }
        }


        internal void OutputArrayDiag(int dim1, int dim2)
        {
            int[,] twoDimens = InitTwoDimArray(dim1, dim2);

            for (int i = 0; i < twoDimens.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimens.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(new string('\t', j) + twoDimens[i, j]);
                    }
                }
                Console.WriteLine();
            }

        }

        private int[,] InitTwoDimArray(int dimen1, int dimen2)
        {
            int[,] tempArr;
            if (dimen1 > 0 && dimen2 > 0)
            {
                tempArr = new int[dimen1, dimen2];

                for (int i = 0; i < tempArr.GetLength(0); i++)
                {
                    for (int j = 0; j < tempArr.GetLength(1); j++)
                    {
                        tempArr[i, j] = new Random().Next(10, 20);
                    }
                }
            }
            else
            {
                throw new NullReferenceException();
            }
            return tempArr;
        }


    }
}
