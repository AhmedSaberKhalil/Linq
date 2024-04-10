using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToObject
{
    public class Course
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public Subject Subject { get; set; }
        public Department Department { get; set; }

        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}
