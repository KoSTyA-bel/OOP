using OOP.Model;
using OOP.Utils;
using OOP.View;
using System.Threading;

namespace OOP
{
    class Program
    {
        static void WorkWithGroup(object message)
        {
            Group group = message as Group;

            double avr = Mananger.GetAverageMark(group.Students);

            Printer.PrintLine(avr.ToString());

            Printer.PrintLine("\nGood students:");
            Printer.PrintLine(Converter.ConvertToStudentsString(
                Mananger.GetListOfStudentsBy(group.Students, avr, (studentMark, mark) => studentMark >= mark)));

            Printer.PrintLine("\nBad students:");
            Printer.PrintLine(Converter.ConvertToStudentsString(
                Mananger.GetListOfStudentsBy(group.Students, avr, (studentMark, mark) => studentMark < mark)));
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(WorkWithGroup);

            School school = new School();
            Group group = new Group();

            group.AddStudent(school.MakeStudent("kirill", 20, 7.5));
            group.AddStudent(school.MakeStudent("lexa", 18, 6));
            group.AddStudent(school.MakeStudent("kostya", 9, 10));

            thread.Start(group);

            //тута выполняет что-то другое
        }
    }
}
