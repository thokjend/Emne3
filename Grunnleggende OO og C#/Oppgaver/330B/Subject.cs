namespace _330B
{
    internal class Subject
    {
        public string Name { get;}
        private string _teacher;
        private int _room;
        private int _capacity;
        private List<Enrollment> _enrollments;


        public Subject(string name, string teacher, int room)
        {
            Name = name;
            _teacher = teacher;
            _room = room;
            _capacity = 50;
            _enrollments = new List<Enrollment>();
        }


        public void AddEnrollment(Enrollment enrollment)
        {
            if (_enrollments.Count < _capacity)
            {
                _enrollments.Add(enrollment);
            }
            else
            {
                Console.WriteLine("Subject is full.");
            }
        }

        public void ShowStudents()
        {
            Console.WriteLine($"Students enrolled in {Name}:");
            foreach (var enrollment in _enrollments)
            {
                Console.WriteLine(enrollment.Student.Name);
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Subject Name: {Name}");
            Console.WriteLine($"Capacity: {_capacity}");
            Console.WriteLine($"Teacher: {_teacher}");
            Console.WriteLine($"Room: {_room}");
            Console.WriteLine($"Students enrolled in subject: {_enrollments.Count}");
            Console.WriteLine($"Available spots: {_capacity - _enrollments.Count}");
        }

    }
}
