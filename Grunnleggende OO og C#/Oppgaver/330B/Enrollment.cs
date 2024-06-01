namespace _330B
{
    internal class Enrollment
    {
        public Student Student { get; }
        public Subject Subject { get; }
        private char _grade;
        private bool _examPassed;
        private bool _examTaken;

        public Enrollment(Student student, Subject subject)
        {
            Student = student;
            Subject = subject;
            _grade = ' ';
            _examPassed = false;
            _examTaken = false;
        }
        public char GetGrade() => _grade;
        public bool IsExamPassed() => _examPassed;
        public bool IsExamTaken() => _examTaken;

        public void SetGrade(char grade)
        {
            _grade = grade;
        }

        public void SetExamPassed(bool examPassed)
        {
            _examPassed = examPassed;
        }

        public void SetExamTaken(bool examTaken)
        {
            _examTaken = examTaken;
        }
    }
}