namespace Assignment1
{
    class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Greet();

            var student = new Student();
            student.SetAge(18);
            student.Greet();
            student.ShowAge();

            var teacher = new Teacher();
            teacher.SetAge(50);
            teacher.Greet();
            teacher.Explain();
        }
    }
}