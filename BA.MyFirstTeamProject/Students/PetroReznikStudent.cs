using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class PetroReznikStudent : IStudent
    {
        public string Email {
            get {
                return "engiPR@gmail.com";
            }
        }

        public string Firstname {
            get {
                return "Petro";
            }
        }

        public string Lastname {
            get {
                return "Reznik";
            }
        }
    }
}
