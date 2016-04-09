using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class YevhenKhatylaiev : IStudent
    {
        public string Email
        {
            get
            {
                return "g.eugeneh@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "Yevhen";
            }
        }

        public string Lastname
        {
            get
            {
                return "Khatylaiev";
            }
        }
    }
}
