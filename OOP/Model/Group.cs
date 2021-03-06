using System.Collections.Generic;
using System.Linq;

namespace OOP.Model
{
    class Group
    {
        private List<Student> _students;

        public List<Student> Students { get => _students; set => _students = value; }

        public Group()
        {
            _students = new List<Student>();
        }

        public Group(List<Student> students)
        {
            _students = students;
        }

        public Group(Student[] students)
        {
            _students = students.ToList();
        }

        public void AddStudent(Student s)
        {
            _students.Add(s);
        }
    }
}
