using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP.Model
{
    static class Mananger
    {
        public static double GetAverageMark(List<Student> students)
        {
            return students.Average(x => x.Mark);
        }

        public static double GetAverageMark(Student[] students)
        {
            return students.Average(x => x.Mark);
        }

        public static List<Student> GetListOfStudentsBy(List<Student> students, double avr, Func<double, double, bool> function)
        {
            return students
                .Where(x => function(x.Mark, avr))
                .ToList();
        }

        public static List<Student> GetListOfStudentsBy(Student[] students, double avr, Func<double, double, bool> function)
        {
            return students
                .Where(x => function(x.Mark, avr))
                .ToList();
        }
    }
}
