namespace Metigator.DesignPattern.SimpleFactory;

public class DishFactory
{
    public static IAppetizer CreateAppetizer(string dishType)
    {
        return dishType switch
        {
            "ChickenSalad" => new ChickenSalad("Small", "350-450", 08.99m, new() { "Chicken", "Lettuce", "Tomatoes", "Cucumbers", "Salad dressing" }),
            "ButterCracker" => new ButterCracker("Small", "70-80", 09.99m, new() { "Flour", "Butter", "Salt" }),
            "CheeseTwist" => new CheeseTwist("Small", "100-150", 07.99m, new() { "Puff pastry", "Cheese", "Egg", "Salt" }),
            "PotatoBite" => new PotatoBite("Small", "200-250", 05.99m, new() { "Potato", "Cheese", "Breadcrumbs", "Egg" }),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public static IMainCourse CreateMainCourse(string dishType)
    {
        return dishType switch
        {
            "Lasagna" => new Lasagna("Large", "300-600", 14.99m, new() { "Pasta", "Cheese", "Tomato", "Beef" }),
            "Steak" => new Steak("Medium", "500-700", 17.99m, new() { "Beef steak", "Salt", "Pepper" }),
            "Molokhiya" => new Molokhiya("Medium", "100-200", 16.99m, new() { "Molokhiya leaves", "Chicken broth", "Garlic", "Coriander" }),
            "GrilledChicken" => new GrilledChicken("Large", "200-300", 15.99m, new() { "Chicken", "Salt", "Pepper", "Paprika" }),
            _ => throw new ArgumentOutOfRangeException()

        };
    }

    public static IDessert CreateDessert(string dishType)
    {
        return dishType switch
        {
            "FruitSalad" => new FruitSalad("Medium", "100-150", 07.99m, new() { "Apple", "Banana", "Orange", "Berries" }),
            "Tiramisu" => new Tiramisu("Small", "400-600", 08.99m, new() { "Ladyfingers", "Coffee", "Egg yolks", "Mascarpone cheese", "Cocoa powder" }),
            "Browny" => new Browny("Medium", "150-250", 07.99m, new() { "Sugar", "Butter", "Cocoa powder", "Eggs", "Flour", "Vanilla extract" }),
            "IceCream" => new IceCream("Small", "200-250", 06.99m, new() { "Milk", "Sugar", "Cream", "Egg yolks", "Vanilla extract" }),
            _ => throw new ArgumentOutOfRangeException()

        };
    }
}
