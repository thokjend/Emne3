using System.Runtime.InteropServices;

namespace _330B
{
    internal class School
    {
        private string _name;
        private int _capacity;
        private List<GradeLevel> _gradeLevels; //Classes
        private List<Student> _students;
        private List<Teacher> _teachers;
        private List<Subject> _subjects;

        public School(string name, int capacity)
        {
            _name = name;
            _capacity = capacity;
            _gradeLevels = new List<GradeLevel>();
            _students = new List<Student>();
            _teachers = new List<Teacher>();
            _subjects = new List<Subject>();
        }


        public Subject AddSubject(string subjectName, string teacher, int room)
        {
            var subject = new Subject(subjectName, teacher, room);
            _subjects.Add(subject);
            return subject;
        }

        public void ShowAllSubjects()
        {
            foreach (var subject in _subjects)
            {
                Console.WriteLine(subject.Name);
            }
        }
    }
}
