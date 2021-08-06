using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._04_Lesson
{
    class task02
    {

        public task02()
        {

            Init();
        }
        string[] numbers;

        private void Init()
        {
            try
            {
                Console.WriteLine("Введите числа через пробел");
                numbers = Console.ReadLine().Split(" ");
                EnterNumAndShowRes(numbers);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public void EnterNumAndShowRes(string[] st)
        {
            Console.WriteLine(ReturnSumNum(st));
        }

        private int ReturnSumNum(IEnumerable<string> stArr)
        {
            int sum = 0;
            foreach (string item in stArr)
            {
                sum += Convert.ToInt32(item);

            }
            return sum;
        }

    }
}
