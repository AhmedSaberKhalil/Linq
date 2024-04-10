using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToObject
{
    public static class SampleData
    {

        public static Department[] Departments =
        {
            new Department{Name="SD",Address="Assiut"},
            new Department{Name="Unix",Address="Alex"},
            new Department{Name="Java",Address="Cairo"},
            new Department{Name="E-Learning",Address="Alex"}
        };

        public static Subject[] Subjects =
        {
            new Subject{Name="Programming",Description="Development Courses"},
            new Subject{Name="Soft Skills",Description="HR Courses"},
            new Subject{Name="Language",Description="Language Courses"}
        };

        public static Course[] Courses =
        {
            new Course{Name="C#",Hours=60,Subject=Subjects[0],Department=Departments[0]},
            new Course{Name="LINQ",Hours=18,Subject=Subjects[0],Department=Departments[0]},
            new Course{Name="Agile",Hours=30,Subject=Subjects[0],Department=Departments[2]},
            new Course{Name="Interview",Hours=18,Subject=Subjects[1],Department=Departments[1]},
            new Course{Name="Flash MX",Hours=45,Subject=Subjects[0],Department=Departments[3]},
            new Course{Name="Communication Skills",Hours=18,Subject=Subjects[1],Department=Departments[1]},
            new Course{Name="English",Hours=45,Subject=Subjects[2],Department=Departments[2]},
        };

        public static ArrayList GetCourses()
        {
            var list = new ArrayList(Courses);
            list.Add("Hello");
            return list;
        }
    }
}
