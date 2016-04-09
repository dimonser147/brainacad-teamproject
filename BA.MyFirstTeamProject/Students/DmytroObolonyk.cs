using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class DmytroObolonyk : IStudent
    {
        public string Email
        {
            get
            {
                return "dimonser147@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "Dmytro";
            }
        }

        public string Lastname
        {
            get
            {
                return "Obolonyk";
            }
        }
    }
}
