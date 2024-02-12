using Assignment4;

internal class Program
{
    private static void Main(string[] args)
    {
        var car = new Car(0);

        Console.WriteLine("Give an amount of gasoline to refuel");

        int amount = int.Parse(Console.ReadLine());

        if (car.Refuel(amount))
        {
            car.Drive();
        }
        
    }
}