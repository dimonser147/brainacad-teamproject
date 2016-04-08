using BA.MyFirstTeamProject.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.MyFirstTeamProject.Utilities
{
    static class StudentHelpers
    {
        public static string ToMarkString(this IStudent student, double mark)
        {
            return $"{student.Lastname} {student.Firstname} mark is {mark} ({student.Email})";
        }
    }
}
