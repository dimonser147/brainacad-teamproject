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
            studentsCollection[8] = new SergeiRopin();
            studentsCollection[2] = new JuliaNeznaeva();
            studentsCollection[3] = new OksanaZinchenko();
            studentsCollection[7] = new DionisiiGrinko();
            studentsCollection[13] = new DmytriyKashkarov();
            studentsCollection[12] = new AleksandrKhomenko();
            studentsCollection[14] = new YuraShariy();


            studentsCollection[9] = new IrinaDemina();
            studentsCollection[10] = new AleksandrBaranov();

            studentsCollection[11] = new TetianaTrukhachova();

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
