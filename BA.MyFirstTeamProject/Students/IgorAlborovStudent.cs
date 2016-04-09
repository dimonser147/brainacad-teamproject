using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class IgorAlborovStudent:IStudent
    {
        public string Email {
            get {
                return "i.alborov@gmail.com";
            }
        }

        public string Firstname {
            get {
                return "Igor";
            }
        }

        public string Lastname {
            get {
                return "Alborov";
            }
        }
    }
}
