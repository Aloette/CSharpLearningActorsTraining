namespace Assignment1
{
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
    }
}