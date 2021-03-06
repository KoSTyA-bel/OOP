using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Model
{
    public class NovogrudocSchool : School
    {
        public override Student MakeStudent(string name, int age, double mark)
        {
            return new Boy(name, age, mark);
        }
    }
}
