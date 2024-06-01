namespace _330B
{
    internal class Student
    {
        public string Name { get; private set; }
        private List<Enrollment> _enrollments;
        private GradeLevel _class;
        

        public Student(string name)
        {
            Name = name;
            _enrollments = new List<Enrollment>();
        }

        public void SetClass(GradeLevel gradeLevel)
        {
            _class = gradeLevel;
        }

        public void AddEnrollment(Enrollment enrollment)
        {
            _enrollments.Add(enrollment);
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Class: {_class}");
            Console.WriteLine("Enrolled Subjects: ");
            foreach (var enrollment in _enrollments)
            {
                var subject = enrollment.Subject;
                Console.WriteLine($"{subject.Name} ");
                Console.WriteLine($"Grade: {enrollment.GetGrade()}");
                Console.WriteLine($"Exam Passed: {enrollment.IsExamPassed()}");
                Console.WriteLine($"Exam Taken: {enrollment.IsExamTaken()}");
            }
        }

    }
}
