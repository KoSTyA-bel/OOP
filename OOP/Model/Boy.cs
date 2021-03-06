using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Model
{
    public class Boy : Student
    {
        //Я проста слишком глубый чтобы нормально обозвать класс
        //КАЮСЬЬЬЬ!!!!
        public const int MAX_AGE = 130;
        public const int MIN_AGE = 0;
        public const int MAX_MARK = 10;
        public const int MIN_MARK = 0;

        public override string Name { get => _name; set => _name = value; }

        public override int Age {
            get => _age;
            set 
            { 
                if (value >= MIN_AGE && value <= MAX_AGE) 
                {
                    _age = value;
                }
            }
        }
        public override double Mark
        {
            get => _mark;
            set
            {
                if (value >= MIN_MARK && value <= MAX_MARK)
                {
                    _mark = value;
                }
            }
        }

        public Boy()
        {
        }

        public Boy(string name, int age, double mark)
        {
            Name = name;
            Age = age;
            Mark = mark;
        }

        public override string ToString()
        {
            return $"{Name}: age = {_age}, mark = {_mark}";
        }
    }
}
