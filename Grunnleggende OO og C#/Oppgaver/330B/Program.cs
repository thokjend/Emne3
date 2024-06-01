namespace _330B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Get Academy", 200);
            var js = school.AddSubject("JavaScript", "Terje", 401);
            var math = school.AddSubject("Math", "Arne", 402);

            var teacher1 = new Teacher("Terje");
            var student1 = new Student("Per");
            var student2 = new Student("Pål");
            var student3 = new Student("Espen");
            var student4 = new Student("Thomas");


            var classA = school.AddClass();
            //classA.AddTeacher();
            classA.AddStudent(student1);
            classA.AddStudent(student2);
            classA.AddStudent(student3);
            classA.AddStudent(student4);
            //classA.Show();


            school.EnrollStudentInSubject(student1, js);
            school.EnrollStudentInSubject(student1, math);

            student1.ShowInfo();

            //js.GetInfo();
            //js.ShowStudents();


            //math.EnrollStudent(student1);
            //math.ShowStudents();

        }
    }
}
