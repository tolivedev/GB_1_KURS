using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._06_Lesson
{
    [Serializable]
    class MyArrayDataException:Exception
    {


        public MyArrayDataException()
        {
            
        }
        public MyArrayDataException(string someData)
        {
            this.Data.Add("Дополнительные сведения ", someData);
        }
    }
}
