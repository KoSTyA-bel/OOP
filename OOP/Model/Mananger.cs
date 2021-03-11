using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP.Model
{
    static class Mananger
    {
        public static double GetAverageMark(IEnumerable<Student> students)
        {
            return students.Average(x => x.Mark);
        }

        public static List<Student> GetListOfStudentsBy(IEnumerable<Student> students, double avr, Func<double, double, bool> function)
        {
            return students
                .Where(x => function(x.Mark, avr))
                .ToList();
        }        
    }
}
