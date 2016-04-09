using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class IvanSakharchuk : IStudent
    {
        public string Email
        {
            get
            {
                return "wanek96@mail.ru";
            }
        }

        public string Firstname
        {
            get
            {
                return "Ivan";
            }
        }

        public string Lastname
        {
            get
            {
                return "Sakharchuk";
            }
        }
    }
}
