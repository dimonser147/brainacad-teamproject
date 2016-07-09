using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class AleksandrBaranovt: IStudent
    {
        public string Email {
            get {
                return "aleksaleksand1@gmail.com";
            }
        }

        public string Firstname {
            get {
                return "Aleksandr";
            }
        }

        public string Lastname {
            get {
                return "Baranov";
            }
        }
    }
}
