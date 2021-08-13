using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons._06_Lesson
{
    enum ErrorCode
    {
        SizeCol,
        SizeRow,
        Size
            
    }
    [Serializable]
    class MySizeArrayException : Exception
    {
        public ErrorCode Code { get; set; }
        public MySizeArrayException(ErrorCode er)
        {
  
            Code = er;
        }
    }
}
