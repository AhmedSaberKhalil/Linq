using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    internal class Program
    {
        class CourseData
        {
            public string Name { get; set; }
            public int Hours { get; set; }
        }
        static CourseData GetData(Course course)
        {
            return new CourseData {Name = course.Name, Hours = course.Hours};
        }
        public static string GetName(Course course)
        {
            return course.Name;
        }
        static void Main(string[] args)
        {


            #region Intro 
            //IEnumerable<Course> courses = SampleData.Courses.Filter(x => x.Hours < 30);
            //foreach (Course crs in courses)
            //{
            //    Console.WriteLine($"Name : {crs.Name} \t Hourse : {crs.Hours}");

            //}
            //int count = SampleData.Courses.MyCount();


            //IEnumerable<CourseData> q = SampleData.Courses.Choose(GetData);
            //foreach (CourseData c in q)
            //{
            //    Console.WriteLine(c.Name);
            //}

            //var query = SampleData.Courses.Select(c => new { c.Name, c.Hours });

            //foreach (var c in query)
            //{
            //    Console.WriteLine($"Name: {c.Name}\t Hours:  {c.Hours}");
            //}

            #endregion

            #region LINQ In Action 
            //IEnumerable<Course> course = SampleData.Courses.Where(c => c.Hours > 30);
            //IEnumerable<string> q = SampleData.Courses.Select(c => c.Name); 
            #endregion

            #region Pipeline 

            // IEnumerable<string> query = SampleData.Courses.Choose(GetName); 

            //IEnumerable<string> query = SampleData.Courses.Choose(c => c.Name);

            //foreach (string name in query)
            //{
            //    Console.WriteLine(name);
            //}

            //IEnumerable<string> course = SampleData.Courses.Where(c => c.Hours > 30).Select(c => c.Name); 
            #endregion


            #region Query Operator 

            //var query = SampleData.Courses.Where(c => c.Hours > 30).Select(c => new { c.Name, c.Hours });

            //foreach (var c in query)
            //{
            //    Console.WriteLine($"Name: {c.Name}\t Hours:  {c.Hours}");
            //}
            #endregion

            #region Query Exoressions  

            //var query = from crs in SampleData.Courses
            //             where crs.Hours > 30
            //             select new { crs.Name, crs.Hours };

            #endregion


            #region First\Last OrDefault()  
            //Course crs = SampleData.Courses.Where(c => c.Hours > 30).First();
            //Course crs = SampleData.Courses.Where(c => c.Hours > 30).Last();
            //Course crs = SampleData.Courses.Where(c => c.Hours > 30).FirstOrDefault();
            //Course crs = SampleData.Courses.Where(c => c.Hours > 30).LastOrDefault(); 
            #endregion

            //   Course crs = SampleData.Courses.Where(c => c.Hours > 30).Max();
            #region Aggregate functions 
            //int count = SampleData.Courses.Where(c => c.Hours > 30).Count();
            //int count = SampleData.Courses.Count(c => c.Hours > 30);

            //int hours = SampleData.Courses.Where(c => c.Hours > 30).Select(c => c.Hours).Sum();
            //int hours = SampleData.Courses.Where(c => c.Name.Contains("c")).Sum(c => c.Hours);

            //int maxHours = SampleData.Courses.Where(c => c.Name.Contains("c")).Select(c => c.Hours).Max();
            //Course course = SampleData.Courses.Where(c => c.Hours > 30).Max(); // throw Exception: At least one object must implement IComparable.
            #endregion

            #region OrderBy
            //var query =
            //    SampleData.Courses.Where(c => c.Hours > 30)
            //    .OrderBy(c => c.Hours) //.OrderByDescending(c => c.Hours)
            //    .Select(c => new { CrsName = c.Name, DeptName = c.Department.Name });
            ////.OrderBy(c => c.);

            //var query =
            //    from c in SampleData.Courses
            //    where c.Hours > 30
            //    orderby c.Hours //descending
            //    select new { CrsName = c.Name, DeptName = c.Department.Name };

            //var query =
            //    SampleData.Courses.Where(c => c.Hours > 30)
            //    .OrderByDescending(c => c.Hours)
            //    .ThenBy(c => c.Department.Name)
            //    .Select(c => new { CrsName = c.Name, DeptName = c.Department.Name, c.Hours });

            //var query =
            //    from c in SampleData.Courses
            //    where c.Hours > 30
            //    orderby c.Hours descending, c.Department.Name
            //    select new { CrsName = c.Name, DeptName = c.Department.Name, c.Hours }; 
            #endregion

            #region Eager Execution
            //IEnumerable<string> query = 
            //    SampleData.Courses.Where(c => c.Hours > 30)
            //    .Select(c => c.Name).ToList();  // القيم بترجع مره واحده Eager excution ل defferd excution بتحول  من
            #endregion

            #region SubQuery 

            //// IEnumerable Of Anonymous
            //var query =  // Select الحاجه اللي بعملها IEumerable of شايل
            //    from s in SampleData.Subjects
            //    select new     // بيبدا من هنا Select ال
            //    {
            //        SubName = s.Name,  // Collections of courses و SubName هيحتوي علي object from Anonymous كل
            //        Courses =           // IEnumerable of Course هيحتوي علي
            //                from c in SampleData.Courses
            //                where c.Subject.Name == s.Name
            //                select c
            //    };


            //var query = SampleData.Subjects.Select(s => new { SubName = s.Name, Courses = SampleData.Courses.Where(c => c.Subject.Name == s.Name) });

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"SubjectNAme: {item.SubName}\t Total Hours: {item.Courses.Sum(c => c.Hours)} \n");

            //    foreach (var c in item.Courses)
            //    {
            //        Console.WriteLine($"Course: {c.Name} \t Hours: {c.Hours}");
            //    }
            //}
            #endregion
            #region Group By  

            //  IEnumerable<IGrouping<string, Course>> query =
            //    var query = 
            //    from crs in SampleData.Courses
            //    group crs by crs.Subject.Name;  // Key اسمها prprity ويكون معاه IEnumerable معاه implement لازم ي IGrouping اللي اسمه implement interface اللي هي
            //foreach (var item in query)  // واحد record الواحد يكون بيعبر عن item عشان ف كل لفه ال
            //{
            //    Console.WriteLine($"SubjectNAme: {item.Key}\t Total Hours: {item.Sum(c => c.Hours)} \n");

            //    foreach (var c in item)
            //    {
            //        Console.WriteLine($"Course: {c.Name} \t Hours: {c.Hours}");
            //    }
            //}

            //var query =
            //from crs in SampleData.Courses
            //    //where crs.Hours < 50   // group لو عايز اعمل فلتر هيبقي هنا قبل ال
            //group crs by crs.Subject.Name into grp  // Key اسمها prprity ويكون معاه IEnumerable معاه implement لازم ي IGrouping اللي اسمه implement interface اللي هي
            //where grp.Count() > 2
            //select (new { SubName = grp.Key, TotalHours = grp.Sum(c => c.Hours), Courses = grp });

            //foreach (var item in query)  // واحد record الواحد يكون بيعبر عن item عشان ف كل لفه ال
            //{
            //    Console.WriteLine($"SubjectNAme: {item.SubName}\t Total Hours: {item.TotalHours} \n");

            //    foreach (var c in item.Courses)
            //    {
            //        Console.WriteLine($"Course: {c.Name} \t Hours: {c.Hours}");
            //    }
            //}
            #endregion


        }

    }
}
