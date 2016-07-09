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


            FakeStudentsManager fakeStudManager = new FakeStudentsManager();
            // TODO: 2. create appropriate students collection and fill it by other students

            IStudent[] studentsCollection = new IStudent[15];
            studentsCollection[0] = new AntonBabich();
            studentsCollection[1] = new SelivanovskyIvan();
            studentsCollection[2] = new JuliaNeznaeva();
            studentsCollection[4] = new IrinaDemina();






          

            // TODO: 3. print marks of all students




            //foreach(IStudent stud in someplace)
            //{
            //Console.WriteLine stud

            //}

        }
    }
}
