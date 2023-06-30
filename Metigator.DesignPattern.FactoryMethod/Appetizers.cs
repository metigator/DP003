namespace Metigator.DesignPattern.FactoryMethod;

public interface IAppetizer : IDish
{
}

public class ChickenSalad : Dish, IAppetizer
{
    public ChickenSalad(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
    public void Serve()
    {
        Console.WriteLine($"Chicken Salad \n▀▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
    }
}
public class ButterCracker : Dish, IAppetizer
{
    public ButterCracker(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
    public void Serve()
    {
        Console.WriteLine($"Butter Cracker \n▀▀▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
    }
}
public class CheeseTwist : Dish, IAppetizer
{
    public CheeseTwist(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
    public void Serve()
    {
        Console.WriteLine($"Cheese Twist \n▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
    }
}
public class PotatoBite : Dish, IAppetizer
{
    public PotatoBite(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
    public void Serve()
    {
        Console.WriteLine($"Potato Bite \n▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
    }
}

