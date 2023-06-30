namespace Metigator.DesignPattern.FactoryMethod;

public interface IMainCourse : IDish
{
}
public class Lasagna : Dish, IMainCourse
{
    public Lasagna(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }

    public void Serve()
    {
        Console.WriteLine($"Lasagna \n▀▀▀▀▀▀▀\n{ShowDetails()}");
    }
}
public class Steak : Dish, IMainCourse
{
    public Steak(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }

    public void Serve()
    {
        Console.WriteLine($"Steak \n▀▀▀▀▀\n{ShowDetails()}");
    }
}
public class Molokhiya : Dish, IMainCourse
{
    public Molokhiya(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
    public void Serve()
    {
        Console.WriteLine($"Molokhiya \n▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
    }
}
public class GrilledChicken : Dish, IMainCourse
{
    public GrilledChicken(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
    public void Serve()
    {
        Console.WriteLine($"Grilled Chicken \n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
    }
}

