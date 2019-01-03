namespace ChallengeStudentCourses
{
    public class Grade
    {
        public string FinalGrade { get; }
        
        public Grade(int score)
        {
            if (score > 89)
                FinalGrade = "A";
            else if (score > 79)
                FinalGrade = "B";
            else if (score > 69)
                FinalGrade = "C";
            else if (score > 59)
                FinalGrade = "D";
            else
                FinalGrade = "F";
        }
    }
}