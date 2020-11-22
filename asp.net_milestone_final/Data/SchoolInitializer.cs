using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net_milestone_final.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_milestone_final.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Nurzhan",LastName="Nauryzbayev",EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{FirstMidName="Mirzhan",LastName="Abdildayev",EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{FirstMidName="Adil",LastName="Kaliyev",EnrollmentDate=DateTime.Parse("20017-09-01")},
            new Student{FirstMidName="Ablaihan",LastName="Bexeit",EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{FirstMidName="Mukhametali",LastName="Orazbek",EnrollmentDate=DateTime.Parse("2017-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="C++",Credits=3,},
            new Course{CourseID=4022,Title="Economics",Credits=3,},
            new Course{CourseID=4041,Title="Mathematics",Credits=3,},
            new Course{CourseID=1045,Title="Java",Credits=4,},
            new Course{CourseID=3141,Title="ASP.NET",Credits=4,},
            new Course{CourseID=2021,Title="Philosophy",Credits=3,},
            new Course{CourseID=2042,Title="Electronics",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.B},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.A},
            new Enrollment{StudentID=3,CourseID=1050, Grade=Grade.B},
            new Enrollment{StudentID=3,CourseID=1050,Grade=Grade.C},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.B},
            new Enrollment{StudentID=4,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=5,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=5,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
