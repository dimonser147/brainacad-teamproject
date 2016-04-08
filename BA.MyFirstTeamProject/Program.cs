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
            // TODO: create students manager
            IStudentsManager studentsManager = new FakeStudentsManager();
            // TODO: create appropriate students collection and fill it by other students
            List<IStudent> students = new List<IStudent>();
            students.Add(new SampleStudent());
            // TODO: print marks of all students
            foreach (IStudent s in students)
            {
                double mark = studentsManager.GetMark(s);
                string ms = s.ToMarkString(mark);
                Console.WriteLine(ms);
            }

        }
    }
}
