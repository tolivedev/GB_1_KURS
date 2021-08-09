using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace Lessons._05_Lesson
{
    class task01
    {
        public task01()
        {
            Console.WriteLine("Введите произвольный текст, будет записан в файл writeFile.txt\n");
            ReadAndWriteData();
        }

        private void ReadAndWriteData()
        {
            //System.IO.StreamWriter SW = 
            using (StreamWriter swr = new StreamWriter(new FileStream("writeFile.txt", FileMode.OpenOrCreate, FileAccess.Write)))
            {
                swr.Write(Console.ReadLine());
                Console.WriteLine("\nWrite done");
            }
            Thread.Sleep(2000);
        }
    }
}
