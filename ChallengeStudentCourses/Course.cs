using System.Collections.Generic;

namespace ChallengeStudentCourses
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public Dictionary<int,Grade> StudentGrades { get; set; }
    }
}