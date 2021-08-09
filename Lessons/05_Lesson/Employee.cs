using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lessons._05_Lesson
{
    class Employee
    {
        private Employee()
        {

        }

        public Employee(string fio, string position, string email, int mobileNum, int salary, int age)
        {
            this.FIO = fio;
            this.Position = position;
            this.Email = email;
            this.MobileNum = mobileNum;
            this.Salary = salary;
            this.Age = age;
        }
        public string FIO { get; private set; }
        public string Position { get; private set; }
        public string Email { get; private set; }
        public int MobileNum { get; private set; }
        public int Salary { get; private set; }
        public int Age { get; private set; }

        // Могу обернуть ToString в указанный по заданию метод.
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", FIO, Position, Email, MobileNum, Salary, Age);
        }

    }
}
