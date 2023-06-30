namespace Metigator.DesignPattern.Before;

public interface IDish
{
    void Serve();
}
public abstract class Dish
{
    public string Size { get; set; }
    public string Calories { get; set; }
    public decimal Price { get; set; }
    public List<string> Ingredients { get; set; }

    public Dish(string size, string calories, decimal price, List<string> ingredients)
    {
        Size = size;
        Calories = calories;
        Price = price;
        Ingredients = ingredients;
    }
    protected string ShowDetails()
    {
        // ├── Size: Medium(100 - 150) cal. ($7.99)
        // └── Ingredients: Apple, Banana, Orange, Berries
        return $"  ├── Size: {Size} ({Calories}) cal. ({Price.ToString("C")})\n  └── Ingredients: {string.Join(", ", Ingredients)}\n";
    }
}




