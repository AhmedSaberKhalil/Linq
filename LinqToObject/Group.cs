using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    internal class Group : List<Course>
    {
        public string Key { get; set; }

        //public List<Course> Courses { get; set; }
    }
}
