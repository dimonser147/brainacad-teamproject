using BA.MyFirstTeamProject.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.MyFirstTeamProject.Utilities;

namespace BA.MyFirstTeamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: 1. create students manager
            IStudentsManager manager = new FakeStudentsManager();
            // TODO: 2. create appropriate students collection and fill it by other students
            var students = new IStudent[15];
            students[0] = new SampleStudent();
            // TODO: 3. print marks of all students
            foreach(IStudent student in students)
            {
                if (student == null)
                    continue;
                Console.WriteLine(student.ToMarkString(manager.GetMark(student)));
            }
        }
    }
}
