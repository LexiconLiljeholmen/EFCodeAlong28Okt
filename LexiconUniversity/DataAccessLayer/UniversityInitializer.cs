using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using LexiconUniversity.Models;

namespace LexiconUniversity.DataAccessLayer {
    public class UniversityInitializer : DropCreateDatabaseAlways<UniversityContext> {

        protected override void Seed(UniversityContext context) {
            var students = new List<Student> { 
                new Student { FirstName="Eva", LastName="Andersson", 
                    EnrollmentDate=DateTime.Parse("2015-09-01") },
                new Student { FirstName="John", LastName="Alexander", EnrollmentDate=DateTime.Parse("2015-10-01") },
                new Student { FirstName="Lisa", LastName="Miskovsky", EnrollmentDate=DateTime.Parse("2015-11-03") },
                new Student { FirstName="Daniel", LastName="Olivetto", EnrollmentDate=DateTime.Parse("2015-10-07") },
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course { CourseId=1050, Title="Chemistry" },
                new Course { CourseId=4022, Title="Mathematics" },
                new Course { CourseId=4041, Title="Physics" },
                new Course { CourseId=1045, Title="History" },
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment { StudentId=1, CourseId=1050, Grade=Grade.A },
                new Enrollment { StudentId=1, CourseId=4022, Grade=Grade.C },
                new Enrollment { StudentId=1, CourseId=4041, Grade=Grade.B },
                new Enrollment { StudentId=2, CourseId=1045, Grade=Grade.B },
                new Enrollment { StudentId=3, CourseId=1050 },
                new Enrollment { StudentId=4, CourseId=1050 },
                new Enrollment { StudentId=4, CourseId=4022, Grade=Grade.F },
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}