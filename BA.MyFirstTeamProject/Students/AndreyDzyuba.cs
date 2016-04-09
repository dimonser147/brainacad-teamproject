using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class AndreyDzyuba : IStudent
    {
        public string Email
        {
            get
            {
                return "andredzyuba@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "Andrey";
            }
        }

        public string Lastname
        {
            get
            {
                return "Dzyuba";
            }
        }
    }
}
