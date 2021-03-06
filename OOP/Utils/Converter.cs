using OOP.Model;
using System;
using System.Collections.Generic;

namespace OOP.Utils
{
    public static class Converter
    {
        public static string ConvertToStudentsString(IEnumerable<Student> students)
        {
            return string.Join(Environment.NewLine, students);
        }
    }
}
