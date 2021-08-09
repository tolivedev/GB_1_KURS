using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;


namespace Lessons._05_Lesson
{
    class task02
    {

        public task02()
        {
            path = "startup.txt";
            FS = new FileStream(path, FileMode.Append, FileAccess.Write);
            AddTimeInFile();
        }
        string path;
        FileStream FS;


        public void AddTimeInFile()
        {
            if (File.Exists(path))
            {
                using (StreamWriter swr = new StreamWriter(FS))
                {
                    swr.Write("{0:T}\n", DateTime.Now);
                }
                Console.WriteLine("Well Done!");
            }
      
            Thread.Sleep(2000);
        }
    }
}
