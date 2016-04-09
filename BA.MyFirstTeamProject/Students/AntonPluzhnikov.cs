using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class AntonPluzhnikov : IStudent
    {
        public string Email
        {
            get
            {
                return "the.pluzhnukov@gmail.com";
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
                return "Pluzhnikov";
            }
        }
    }
}
