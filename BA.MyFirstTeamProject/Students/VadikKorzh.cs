using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class VadikKorzh : IStudent
    {
        string IStudent.Email
        {
            get
            {
                return "mynick@ukr.net";
            }
        }

        string IStudent.Firstname
        {
            get
            {
                return "Vadik";
            }
        }

        string IStudent.Lastname
        {
            get
            {
                return "Korzh";
            }
        }
    }
}
