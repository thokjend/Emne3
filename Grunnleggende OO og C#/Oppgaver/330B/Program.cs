namespace _330B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Get Academy", 200);
            var js = school.AddSubject("JavaScript", "Terje", 401);
            var math = school.AddSubject("Math", "Arne", 402);

            var classA = school.AddClass();
            classA.AddTeacher();
            classA.AddStudent();


            var student1 = new Student("Per");
            var student2 = new Student("Pål");
            var student3 = new Student("Espen");
            var student4 = new Student("Thomas");

            school.EnrollStudentInSubject(student1, js);

            js.GetInfo();
            js.ShowStudents();


            //math.EnrollStudent(student1);
            //math.ShowStudents();

        }
    }
}
