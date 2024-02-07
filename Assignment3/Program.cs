using Assignment3;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please give a dog name");
        var dog = new Dog();
        dog.SetName(Console.ReadLine());
        Console.WriteLine("{0} is...", dog.GetName());
        dog.Eat();
    }
}