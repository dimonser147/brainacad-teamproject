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
            IStudent me = new DmytroObolonyk();

            IStudent antonPluzhnikov = new AntonPluzhnikov();


            // TODO: 1. create students manager
            IStudentsManager StudentsManager = new FakeStudentsManager();

            
            // TODO: 2. create appropriate students collection and fill it by other students
            // TODO: 3. print marks of all students
        }
    }
}
