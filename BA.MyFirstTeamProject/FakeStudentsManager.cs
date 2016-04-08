using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.MyFirstTeamProject.Students;

namespace BA.MyFirstTeamProject
{
    class FakeStudentsManager : IStudentsManager
    {
        public double GetMark(IStudent student)
        {
            return RandomProvider.GetThreadRandom().Next(100);
        }
    }
}
