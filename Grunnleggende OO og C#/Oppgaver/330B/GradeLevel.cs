namespace _330B
{
    internal class GradeLevel
    {
        private string _teacher;
        private List<Student> _students;

        public GradeLevel()
        {
            _students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void Show()
        {
            Console.WriteLine($"Students in Class");
            foreach (var student in _students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
