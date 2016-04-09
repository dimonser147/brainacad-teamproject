using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class GlushenkoBorys : IStudent
    {
        public string Email {
            get {
                return "borisss@list.ru";
            }
        }

        public string Firstname {
            get {
                return "Borys";
            }
        }

        public string Lastname {
            get {
                return "Glushenko";
            }
        }
    }
}
