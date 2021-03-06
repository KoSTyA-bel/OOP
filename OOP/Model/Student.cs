using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Model
{
    public abstract class Student
    {
        protected string _name;
        protected int _age;
        protected double _mark;

        public virtual string Name { get => _name; set => _name = value; }
        public virtual int Age { get => _age; set => _age = value; }
        public virtual double Mark { get => _mark; set => _mark = value; }
    }
}
