using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace Lessons._05_Lesson
{
    class task03
    {
        public task03()
        {
            Init();
        }

        BinaryWriter BW;
        FileStream FS;

        
        private void Init()
        {
            string path = "File.bin";
            string dirPath = string.Empty;
            FS = new FileStream(path, File.Exists(path) ? FileMode.Append : FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
            Console.WriteLine("Ввести с клавиатуры произвольный набор чисел(0...255)");
            binFWriter(ReadAndCheckStr());
        }

        public List<int> ReadAndCheckStr()
        {
            List<int> li = new List<int>();
            List<string> cs = new List<string>(Console.ReadLine().Split(' '));

            foreach (string item in cs)
            {
                if (int.TryParse(item, out int number) && number > -1 && number < 256)
                {
                    li.Add(number);
                }
            }
            return li;
        }

        public void binFWriter(IEnumerable<int> str)
        {
            using (BW = new BinaryWriter(FS))
            {
                List<int> ls = str as List<int>;
                if (ls !=null)
                {
                    foreach (var item in ls)
                    {
                        BW.Write(item);
                    }
                    Console.WriteLine("Write Done!\n");
                }
            }

        }

    }
}

