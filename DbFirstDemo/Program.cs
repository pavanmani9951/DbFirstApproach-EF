using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new DbFirstDemoDbContext();
            var courses = db.GetCourses();
            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
            }

        }
    }
}
