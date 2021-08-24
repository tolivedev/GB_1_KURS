using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._07_Lesson
{
    class task02
    {
        public task02()
        {
            Start();

        }
        static int SIZE_X = 5;
        static int SIZE_Y = 5;
        static int SIZE_WIN = 4;

        static char[,] field = new char[SIZE_Y, SIZE_X];

        static char PLAYER_DOT = 'X';
        static char AI_DOT = 'O';
        static char EMPTY_DOT = '.';

        static Random random = new Random();

        private void Start()
        {

            InitField();
            PrintField();
            do
            {
                playerMove();
                Console.WriteLine("Ваш ход на поле");
                PrintField();
                if (CheckWin(PLAYER_DOT))
                {
                    Console.WriteLine("Вы выиграли");
                    break;
                }
                else if (IsFieldFull()) break;
                AiMove();
                Console.WriteLine("Ход Компа на поле");
                PrintField();
                if (CheckWin(AI_DOT))
                {
                    Console.WriteLine("Выиграл Комп");
                    break;
                }
                else if (IsFieldFull()) break;
            } while (true);
            Console.WriteLine("!Конец игры!");
            Console.ReadLine();
        }

        private static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    //Console.Write(field[j, i] + "|");
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------");
        }

        private static void SetSym(int y, int x, char sym)
        {

            field[y, x] = sym;
        }

        private static bool IsCellValid(int y, int x)  // пустая ли клетка
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        private static bool IsFieldFull()  // ничья
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void playerMove()
        {
            int x, y;
            do
            {
                Console.WriteLine("Координат по строке ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_Y);
                x = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Координат по столбцу ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_X);
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));

            SetSym(y, x, PLAYER_DOT);
        }

        private static int CheckLineDiagUp(int v, int h, char sym)
        {
            int counter = 0;
            for (int i = 0, j = 0; j < SIZE_WIN; i--, j++)
            {
                if (field[v + i, h + j] == sym)
                {
                    counter++;
                }
            }
            return counter;
        }

        private static int CheckDiagDown(int v, int h, char sym)
        {
            int counter = 0;

            for (int i = 0; i < SIZE_WIN; i++)
            {
                if (field[i + v, i + h] == sym)
                {
                    counter++;
                }
            }
            return counter;
        }

        private static int CheckLineHoriz(int v, int h, char sym)
        {
            int counter = 0;

            for (int j = h; j < SIZE_WIN + h; j++)
            {
                if (field[v, j] == sym)
                {
                    counter++;
                }
            }
            return counter;
        }

        private static int CheckLineVert(int v, int h, char sym)
        {
            int counter = 0;
            for (int i = v; i < SIZE_WIN + v; i++)
            {
                if (field[i, h] == sym)
                {
                    counter++;
                }
            }
            return counter;
        }


        private static bool CheckWin(char sym)
        {
            for (int v = 0; v < SIZE_Y; v++)
            {
                for (int h = 0; h < SIZE_X; h++)
                {
                    if (h + SIZE_WIN <= SIZE_X) // наберется ли клеткок для победной серии по горизонтали
                    {
                        if (CheckLineHoriz(v, h, sym) >= SIZE_WIN) // по горизонтали
                        {
                            return true;
                        }
                        if (v - SIZE_WIN > -2)
                        {
                            if (CheckLineDiagUp(v, h, sym) >= SIZE_WIN) // вверх диагональ. для диагонали всегда свойственно увеличение горизонтали
                            {
                                return true;
                            }
                        }
                        if (v + SIZE_WIN <= SIZE_Y)
                        {
                            if (CheckDiagDown(v, h, sym) >= SIZE_WIN) // вниз диагональ. для диагонали всегда свойственно увеличение горизонтали
                            {
                                return true;
                            }
                        }
                    }
                    if (v + SIZE_WIN <= SIZE_Y) // наберется ли клеткок для победной серии по вертикали
                    {
                        if (CheckLineVert(v, h, sym) >= SIZE_WIN) // по вертикали
                        {
                            return true;
                        }

                    }
                }
            }
            return false;
        }



        private static void AiMove()
        {
            int x, y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }
    }
}