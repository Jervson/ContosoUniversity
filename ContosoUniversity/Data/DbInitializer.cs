using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student() {FirstMidName="Suss", LastName="Mägi", EnrollmentDate=DateTime.Parse("1973-09-01") },
                new Student() {FirstMidName="Juss", LastName="Mägi", EnrollmentDate=DateTime.Parse("1973-09-01") },
                new Student() {FirstMidName="Vuss", LastName="Mägi", EnrollmentDate=DateTime.Parse("1973-09-01") },
                new Student() {FirstMidName="Luss", LastName="Mägi", EnrollmentDate=DateTime.Parse("1973-09-01") },
                new Student() {FirstMidName="Kuss", LastName="Mägi", EnrollmentDate=DateTime.Parse("1973-09-01") }
            };

            foreach (Student s in students) 
            {
                context.Students.Add(s);    
            }
            context.SaveChanges();

            var instructors = new Instructor[] 
            { 
                new Instructor {FirstMidName = "Bat", LastName = "Man"}
            };

            var courses = new Course[]
            {
                new Course() {CourseID=1050, Title="Programming", Credits=160},
                new Course() {CourseID=2050, Title="Chemistry", Credits=160},
                new Course() {CourseID=3050, Title="Mathematics", Credits=160},
                new Course() {CourseID=4050, Title="PE", Credits=160},
                new Course() {CourseID=5050, Title="Physics", Credits=160}
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();


            var enrollments = new Enrollment[]
            {
                new Enrollment() {StudentID=1, CourseID=1050, Grade=Grade.A},
                new Enrollment() {StudentID=3, CourseID=2050, Grade=Grade.B},
                new Enrollment() {StudentID=3, CourseID=3050, Grade=Grade.C},
                new Enrollment() {StudentID=4, CourseID=4050, Grade=Grade.D},
                new Enrollment() {StudentID=5, CourseID=5050, Grade=Grade.F},
                new Enrollment() {StudentID=5, CourseID=1050, Grade=Grade.A},
                new Enrollment() {StudentID=4, CourseID=3050, Grade=Grade.B},
                new Enrollment() {StudentID=3, CourseID=5050, Grade=Grade.C},
                new Enrollment() {StudentID=3, CourseID=4050, Grade=Grade.D},
                new Enrollment() {StudentID=1, CourseID=5050, Grade=Grade.F},
                new Enrollment() {StudentID=1, CourseID=2050, Grade=Grade.A},
                new Enrollment() {StudentID=4, CourseID=2050, Grade=Grade.B}
            };

            foreach (Enrollment c in enrollments)
            {
                context.Enrollments.Add(c);
            }
            context.SaveChanges();
        }
    }
}
