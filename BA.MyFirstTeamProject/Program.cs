﻿using BA.MyFirstTeamProject.Students;
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
            studentsCollection[2] = new SergeiRopin();
            studentsCollection[3] = new JuliaNeznaeva();
            studentsCollection[4] = new OksanaZinchenko();
            studentsCollection[5] = new DionisiiGrinko();
            studentsCollection[6] = new DmytriyKashkarov();
            studentsCollection[7] = new AleksandrKhomenko();



            studentsCollection[8] = new IrinaDemina();
            studentsCollection[9] = new AleksandrBaranov();

            studentsCollection[10] = new TetianaTrukhachova();

            // TODO: 3. print marks of all students



            int i = 0;
            foreach (IStudent stud in studentsCollection)
            {
                if (stud != null)
                {
                    i++;
                    Console.WriteLine(i.ToString()+": "+ stud.ToMarkString( fakeStudManager.GetMark(stud)));
                }
            }

            Console.ReadLine();

        }
    }
}
