using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class AntonBabich : IStudent
    {
        public string Email
        {
            get
            {
                return "anton.babich@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "Anton";
            }
        }

        public string Lastname
        {
            get
            {
                return "Babich";
            }
        }
    }
}
