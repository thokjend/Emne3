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
    }
}