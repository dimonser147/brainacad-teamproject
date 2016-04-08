using BA.MyFirstTeamProject.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject
{
    interface IStudentsManager
    {
        /// <summary>
        /// Get mark for the first test
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        double GetMark(IStudent student);
    }
}
