using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._04_Lesson
{
    class task01
    {
        public task01()
        {
            flag = true;
            fioDB = new string[0];

            Init();
        }

        string[] fioDB;
        bool flag;

        private void Init()
        {
            Console.WriteLine(@"Введите
Фамилию:
Имя:
Отчество:

через Enter(\r)
Для полноценной работы, по заданию, необходимо ввести не менее четырех ФИО.
Для завершения ввода введите END");
            do
            {

                string[] st = new string[3];
                for (int i = 0; i < 3; i++)
                {

                    string word = Console.ReadLine();
                    if (string.Empty == word)
                    {
                        continue;

                    }
                    else if (word != "END")
                    {
                        st[i] = word;
                    }
                    else { flag = false; break; }
                }


                if (st.Length != 0 && st.Length > 2 && st[0] != "END")
                {

                    for (int i = 0; i < st.Length; i += 3)
                    {

                        AddItemToArr(GetFullName(st[i], st[i + 1], st[i + 2]));

                    }

                }
                else { break; }

            }
            while (flag);

            ShowThreeFourFIO(fioDB);
            Console.WriteLine("Задача окончена");
        }


        private void AddItemToArr(string item)
        {
            string[] tmpArr = new string[fioDB.Length + 1];

            for (int i = 0; i < fioDB.Length; i++)
            {
                tmpArr[i] = fioDB[i];
            }
            tmpArr[fioDB.Length] = item;
            fioDB = tmpArr;
        }


        public string GetFullName(string firstName, string lastName, string patronymic)
        {


            return string.Format("{0} {1} {2}", firstName, lastName, patronymic);

        }

        public void ShowThreeFourFIO(params string[] val)
        {

            if (fioDB.Length > 3)
            {
                Console.WriteLine("\nВывожу список: \n");
                int rnd = new Random().Next(3, 4);
                for (int i = 0; i < rnd; i++)
                {
                    Console.WriteLine(fioDB[i]);
                }
                flag = false;
            }
            else
            {
                Console.WriteLine("\nВ базе меньше трех значений");
                return;
            }
        }
    }
}
