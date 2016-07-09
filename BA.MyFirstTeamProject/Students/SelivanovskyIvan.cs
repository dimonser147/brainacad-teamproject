using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class SelivanovskyIvan : IStudent
    {
        public string Email
        {
            get
            {
                return "selivanovsky@mail.ua";
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
                return "Selivanovsky";
            }
        }
    }
}
