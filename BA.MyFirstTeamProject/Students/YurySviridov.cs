using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class YurySviridov : IStudent
    {
        public string Email
        {
            get
            {
                return "ferro5@inbox.ru";
            }
        }

        public string Firstname
        {
            get
            {
                return "Yury";
            }
        }

        public string Lastname
        {
            get
            {
                return "Sviridov";
            }
        }
    }
}
