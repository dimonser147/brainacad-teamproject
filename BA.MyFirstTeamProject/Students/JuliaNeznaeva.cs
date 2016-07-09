using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class JuliaNeznaeva : IStudent
    {
        public string Email {
            get {
                return "Julia.Neznaeva@gmail.com";
            }
        }

        public string Firstname {
            get {
                return "Julia";
            }
        }

        public string Lastname {
            get {
                return "Neznaeva";
            }
        }
    }
}
