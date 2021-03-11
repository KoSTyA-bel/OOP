using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Model
{
    public interface IMakeStudent
    {
        Student MakeStudent(string name, int age, double mark);
    }
}
