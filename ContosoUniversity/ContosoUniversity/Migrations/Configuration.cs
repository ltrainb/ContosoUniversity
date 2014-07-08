namespace ContosoUniversity.Migrations
{
    using ContosoUniversity.Models
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContosoUniversity.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContosoUniversity.DAL.SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student { FirstName= "Carson", LastName="Alexznader", EnrollmentDate=DateTime.Parse("2010-09-01")},
                new Student{  FirstName= "Meredith", LastName="Alonso", EnrollmentDate=DateTime.Parse("2012-09-01")},
                new Student{ FirstName="Arturo", LastName="Anand", EnrollmentDate=DateTime.Parse("2013-09-01")},
                new Student{ FirstName= "Gytis", LastName="Barzdukas", EnrollmentDate=DateTime.Parse("2012-09-01")},
                new Student{ FirstName= "Yan", LastName="Li", EnrollmentDate=DateTime.Parse("2012-09-01")},
                new Student{ FirstName="Peggy", LastName="Justice", EnrollmentDate=DateTime.Parse("2011-09-01")},
                new Student{ FirstName="Laura" , LastName="Norman", EnrollmentDate=DateTime.Parse("2013-09-01")},
                new Student{ FirstName="Nino", LastName="Olivetto", EnrollmentDate=DateTime.Parse("2005-08-11")}
            };
            students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();
            
            var courses= new List<Course>
            {
                new Course{ CourseID= 1050, Title="Chemistry", Credits=3, },
                new Course{ CourseID= 4022, Title="Microeconomics", Credits=3, },
                new Course{ CourseID=4041, Title="Macroeconomics", Credits=3, },
                new Course{ CourseID= 1045, Title="Calculus", Credits=4, },
                new Course{ CourseID=3141, Title="Trigonmetry", Credits=4, },
                new Course{ CourseID=2021, Title="Composition", Credits=3, },
                new Course{ CourseID=2042, Title="Literature", Credits=4, }
            };
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();

            var enrollments=new List<Enrollment>
            {
                new Enrollment{ StudentID=students.Single(s => s.LastName=="Alexander").ID,}
            }
        }
    }
}
