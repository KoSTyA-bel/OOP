using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Model
{
    public class School : IMakeStudent 
    {
        public Student MakeStudent(string name, int age, double mark)
        {
            //return new Student(name, age, mark);
            return new Student()
            {
                Name = name,
                Age = age,
                Mark = mark
            };
        }
    }
}
