using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Model
{
    public abstract class School
    {
        public abstract Student MakeStudent(string name, int age, double mark);
    }
}
