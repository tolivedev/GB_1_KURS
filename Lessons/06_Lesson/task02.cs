using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lessons._06_Lesson
{

    class task02
    {
        public task02()
        {
        M:
            try
            {

                string[,] sAr = GenArray(4, 4);

                CheckArr(sAr);
                //CheckArr(strArr);

                Thread.Sleep(3000);
            }
            catch (MySizeArrayException ex) when (ex.Code == ErrorCode.SizeCol || ex.Code == ErrorCode.SizeRow)
            {
                Console.WriteLine("Массив несоответствующей величины. Треубется размерность [4,4]");
            }
            catch (MyArrayDataException ex)
            {
                foreach (DictionaryEntry item in ex.Data)
                {
                    Console.WriteLine("{0} : {1}", item.Key, item.Value);
                }

            }
            catch
            {
                Console.WriteLine("Упс, давай повторим");
                goto M;
            }
        }


        string[,] strArr = {
                {"1","1","1","1"},
                { "2", "2", "2", "2" },
                { "3", "3", "3", "3" },
                { "4", "4", "4" ,"4"},
            };

        string[][] jaggedArr = {
                new []{"1","1","1"},
                new []{ "2", "2", "2", "2" },
                new []{ "3", "3", "3", "3" },
                new []{ "4", "4", "4" ,"4","4"},
            };


        private void ShowArr(string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i, 0]);
            }
        }

        private void CheckArr(string[,] arr)
        {
            if (arr.GetLength(0) != 4)
            {
                throw new MySizeArrayException(ErrorCode.SizeCol);
            }
            else if (arr.GetLength(1) != 4)
            {
                throw new MySizeArrayException(ErrorCode.SizeRow);
            }

            SumElemofArray(arr);
        }

        private string[,] GenArray(int col, int row)
        {
            Random rnd = new Random();
            string[,] arr = new string[col, row];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(1, 10).ToString();
                }
            }
            arr[new Random().Next(0, 3), new Random().Next(0, 3)] = "A";
            return arr;
        }

        private void SumElemofArray(string[,] arr)
        {
            int sum = 0;
            MyArrayDataException me = new MyArrayDataException();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (!int.TryParse(arr[i, j], out int result))
                    {
                        me.Data.Add("Причина исключения ", "Данные не могут быть преобразованы к int");
                        me.Data.Add("Индекс проблемной ячейки i j ", $"{i} {j}");
                        me.Data.Add("Содержит в себе ", $"{arr[i, j]}");
                        me.Data.Add("Итого в сумме до исключения ", sum);

                        throw me;
                    }
                    sum += result;
                }
            }
            Console.WriteLine($"Сумма всех элементов {sum}");
        }


    }
}
