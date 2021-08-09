using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Linq;

namespace Lessons._05_Lesson
{
    class task04
    {
        public task04()
        {
            List<Employee> ls = new List<Employee>();
            ls.Add(new Employee("111", "111", "111", 75876786, 2000, 39));
            ls.Add(new Employee("444", "444", "444", 75876786, 1999, 42));
            ls.Add(new Employee("555", "555", "555", 75876786, 2555, 43));
            ls.Add(new Employee("222", "222", "222", 75876786, 3000, 40));
            ls.Add(new Employee("333", "333", "333", 75876786, 2500, 41));


            Output(ls);

            Thread.Sleep(4000);

        }

        private void Output(IEnumerable enmrbl)
        {
            var empls = enmrbl as List<Employee>;
            if (empls != null)
            {
                var query = from Employee n in enmrbl
                            orderby n.FIO
                            where (n.Age > 40)
                            select n;

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }

        }


    }
}
