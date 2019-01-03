using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */ 

            List<Student> cSharp101Students = new List<Student>()
            {
                new Student{Courses = new List<Course>(), Name = "Mark Jacobs", StudentId = 112},
                new Student{Courses = new List<Course>(), Name = "Spencer Stewart", StudentId = 345},
                new Student{Courses = new List<Course>(), Name = "Tyler Smith", StudentId = 768},
                new Student{Courses = new List<Course>(), Name = "Nate Peterson", StudentId = 490},
            };

            List<Student> htmlAndCsStudents = new List<Student>()
            {
                new Student{Courses = new List<Course>(), Name = "Tina Todd", StudentId = 446},
                new Student{Courses = new List<Course>(), Name = "Martha Smalls", StudentId = 809},
                new Student{Courses = new List<Course>(), Name = "Sky Jenner", StudentId = 396},
            };

            List<Student> cSharp202Students = new List<Student>()
            {
                new Student{Courses = new List<Course>(), Name = "Paul Walker", StudentId = 561},
                new Student{Courses = new List<Course>(), Name = "Peter Pan", StudentId = 677},
                new Student{Courses = new List<Course>(), Name = "Michael Scott", StudentId = 294},
            };

            List<Course> courses = new List<Course>()
            {
                new Course(){CourseId = 123, Name = "CSharp 101", Students = cSharp101Students},
                new Course(){CourseId = 234, Name = "HTML & CSS 101", Students = htmlAndCsStudents},
                new Course(){CourseId = 456, Name = "CSharp 202", Students = cSharp202Students},
            };

            foreach (var course in courses)
            {
                resultLabel.Text += $"<h3>{course.Name} - {course.CourseId}</h3>";
                foreach (var courseStudent in course.Students)
                {
                    resultLabel.Text += $"&nbsp&nbsp&nbsp&nbsp&nbspName: {courseStudent.Name} ID: {courseStudent.StudentId}</br>";
                }
            }

        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */ 


        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */ 


        }
    }
}