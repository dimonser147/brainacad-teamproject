using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class AndreiMatveev : IStudent
    {
        public string Email {
            get {
                return "matveev-a1990@mail.ru";
            }
        }

        public string Firstname {
            get {
                return "Andrei";
            }
        }

        public string Lastname {
            get {
                return "Matveev";
            }
        }
    }
}
