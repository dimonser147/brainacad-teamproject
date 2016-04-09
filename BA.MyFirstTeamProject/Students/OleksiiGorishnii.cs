using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class OleksiiGorishnii:IStudent
    {
        public string Email
        {
            get
            {
                return "agorishniy@ukr.net";
            }
        }

        public string Firstname
        {
            get
            {
                return "Oleksii";
            }
        }

        public string Lastname
        {
            get
            {
                return "Gorishnii";
            }
        }

    }
}
