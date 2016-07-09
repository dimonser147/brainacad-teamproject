using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class DmytriyKashkarov : IStudent
    {
        public string Email
        {
            get
            {
                return "dimakashkarov@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "Dmytiy";
            }
        }

        public string Lastname
        {
            get
            {
                return "Kashkarov";
            }
        }

    }
}
