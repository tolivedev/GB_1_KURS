using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._08_Lesson
{
    class task01
    {
        public task01()
        {
            Spiral();
        }

        private static void ShowArray(int[,] array)
        {
            int ro = array.GetLength(1), co = array.GetLength(0);

            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    Console.Write("{0, 3}", array[r, c]);
                }
                Console.WriteLine();
            }
        }
        private void Spiral()
        {
            Console.Write("Enter a size of array NxM via Enter: \n");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] arrayMatr = new int[n, m];
            int row = 0;
            int col = 0;
            string direction = "right";

            for (int i = 1; i <= arrayMatr.Length; i++)
            {
                if ((direction == "right") && (col > m - 1 || arrayMatr[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                else if ((direction == "down") && (row > n - 1 || arrayMatr[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                else if ((direction == "left") && (col < 0 || arrayMatr[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }
                else if ((direction == "up") && (row < 0 || arrayMatr[row, col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                arrayMatr[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                else if (direction == "down")
                {
                    row++;
                }
                else if (direction == "left")
                {
                    col--;
                }
                else if (direction == "up")
                {
                    row--;
                }
            }

            ShowArray(arrayMatr);

            Console.ReadKey();
        }
    }
}
