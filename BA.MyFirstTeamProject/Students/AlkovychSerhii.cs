using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class AlkovychSerhii : IStudent
    {
        public string Email
        {
            get
            {
                return "loost1k22@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "Serhii";
            }
        }

        public string Lastname
        {
            get
            {
                return "Alkovych";
            }
        }
    }
}
