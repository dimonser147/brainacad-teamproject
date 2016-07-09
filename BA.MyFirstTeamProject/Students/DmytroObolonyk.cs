using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Students
{
    public class DmytroObolonyk : IStudent
    {
        public string Email
        {
            get
            {
                return "dima@gmail.com";
            }
        }

        public string Firstname
        {
            get
            {
                return "name";
            }
        }

        public string Lastname
        {
            get
            {
                return "lastname";
            }
        }
    }
}
