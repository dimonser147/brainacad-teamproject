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
        static void Main(string[] args) {
            // TODO: 1. create students manager h
            FakeStudentsManager fakeStudManager = new FakeStudentsManager();

            // TODO: 2. create appropriate students collection and fill it by other students
            IStudent[] studentsCollection = new IStudent[15];
            studentsCollection[0] = new AntonBabich();
            studentsCollection[1] = new SelivanovskyIvan();
            studentsCollection[2] = new AntonNaprasnic();
            studentsCollection[3] = new SergeiRopin();
            studentsCollection[4] = new JuliaNeznaeva();
            studentsCollection[5] = new OksanaZinchenko();
            studentsCollection[6] = new DionisiiGrinko();
            studentsCollection[7] = new DmytriyKashkarov();
            studentsCollection[8] = new AleksandrKhomenko();
            studentsCollection[9] = new YuraShariy();
            studentsCollection[10] = new IrinaDemina();
            studentsCollection[11] = new AleksandrBaranov();
            studentsCollection[12] = new TetianaTrukhachova();
            studentsCollection[13] = new KryvenokMihail();

            // TODO: 3. print marks of all students
            int i = 0;
            foreach (IStudent stud in studentsCollection)
            {
                if (stud != null)
                {
                    i++;
                    Console.WriteLine(i + ": " + stud.ToMarkString(fakeStudManager.GetMark(stud)));
                }
            }
            Console.ReadLine();
        }
    }
}
