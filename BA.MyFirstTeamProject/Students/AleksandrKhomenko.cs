using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    class AleksandrKhomenko : IStudent

    {
        public string Email
        {
            get
            {
                return "sashakhomenko82@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "Aleksandr";
            }
        }

        public string Lastname
        {
            get
            {
                return "Khomenko";
            }
        }
    }
}
