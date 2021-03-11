using System.Collections.Generic;
using System.Linq;

namespace OOP.Model
{
    class Group
    {
        public Group()
        {
            Students = new List<Student>();
        }

        public Group(IEnumerable<Student> students)
        {
            Students = students.ToList();
        }

        public List<Student> Students { get; set; }       

        public void AddStudent(Student s)
        {
            Students.Add(s);
        }
    }
}
