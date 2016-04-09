using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class MaksymPereshybkin : IStudent
    {
        public string Email
        {
            get
            {
                return "max.prs@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "Maksym";
            }
        }

        public string Lastname
        {
            get
            {
                return "Pereshybkin";
            }
        }
    }
}
