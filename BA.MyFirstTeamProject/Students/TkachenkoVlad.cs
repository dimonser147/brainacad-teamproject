using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class TkachenkoVlad : IStudent
    {
        public string Email
        {
            get
            {
                return "tkachenko94ua@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "Vlad";
            }
        }

        public string Lastname
        {
            get
            {
                return "Tkachenko";
            }
        }
    }
}
