namespace _330B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Get Academy", 200);
            var js = school.AddSubject("JavaScript", "Terje", 401);
            var math = school.AddSubject("Math", "Arne", 402);


            var student1 = new Student("Per");
            var student2 = new Student("Pål");
            var student3 = new Student("Espen");
            var student4 = new Student("Thomas");

            js.EnrollStudent(student1);
            js.EnrollStudent(student2);
            js.EnrollStudent(student3);
            js.EnrollStudent(student4);

            math.GetInfo();


            //math.EnrollStudent(student1);
            //math.ShowAllStudents();


        }
    }
}
