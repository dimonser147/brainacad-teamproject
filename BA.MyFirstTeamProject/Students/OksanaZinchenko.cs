using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    public class OksanaZinchenko : IStudent
    {
        public string Email
        {
            get
            {
                return "oksanazinchenkoqa@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "Oksana";
            }
        }

        public string Lastname
        {
            get
            {
                return "Zinchenko";
            }
        }
    }
}
