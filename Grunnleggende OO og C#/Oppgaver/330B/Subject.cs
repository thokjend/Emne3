namespace _330B
{
    internal class Subject
    {
        public string Name { get;}
        private string _teacher;
        private int _room;
        private int _capacity;
        private List<Student> _students;


        public Subject(string name, string teacher, int room)
        {
            Name = name;
            _teacher = teacher;
            _room = room;
            _students = new List<Student>();
            _capacity = 50;
        }


        public void EnrollStudent(Student student)
        {
            _students.Add(student);
        }

        public void ShowAllStudents()
        {
            Console.WriteLine($"Students enrolled in {Name}:");
            foreach (var student in _students)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Subject Name: {Name}");
            Console.WriteLine($"Capacity: {_capacity}");
            Console.WriteLine($"Teacher: {_teacher}");
            Console.WriteLine($"Room: {_room}");
            Console.WriteLine($"Students enrolled in subject: {_students.Count}");
            Console.WriteLine($"Available spots: {_capacity - _students.Count}");
        }

    }
}
