namespace Metigator.DesignPattern.Before;

public interface IDessert : IDish
{
}
public class FruitSalad : Dish, IDessert
{
    public FruitSalad(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
    public void Serve()
    {
        Console.WriteLine($"Fruit Salad \n▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
    }
}
public class Tiramisu : Dish, IDessert
{
    public Tiramisu(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
    public void Serve()
    {
        Console.WriteLine($"Tiramisu \n▀▀▀▀▀▀▀▀\n{ShowDetails()}");
    }
}
public class Browny : Dish, IDessert
{
    public Browny(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
    public void Serve()
    {
        Console.WriteLine($"Browny \n▀▀▀▀▀▀\n{ShowDetails()}");
    }
}
public class IceCream : Dish, IDessert
{
    public IceCream(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
    public void Serve()
    {
        Console.WriteLine($"Ice Cream \n▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
    }
}