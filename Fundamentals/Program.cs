// See https://aka.ms/new-console-template for more information

public enum CarType
{
    Toyota = 1,
    Benz = 2,
    RollsRoys = 3,
}

public class Program {
    public static void Main()
    {
        Console.ReadLine();
        Console.WriteLine(Console.ReadLine());
        CarType myCarType = CarType.Benz;
        Console.WriteLine(myCarType);
    }
}