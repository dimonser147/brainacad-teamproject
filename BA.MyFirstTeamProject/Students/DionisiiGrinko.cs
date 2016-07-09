using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class DionisiiGrinko : IStudent;
    {
        public string Email
        {
            get
            {
                return "byba.dolce@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "Dionisii";
            }
        }

        public string Lastname
        {
            get
            {
                return "Grinko";
            }
        }
    }
}
