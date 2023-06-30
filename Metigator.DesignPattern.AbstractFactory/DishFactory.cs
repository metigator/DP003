namespace Metigator.DesignPattern.AbstractFactory;

public abstract class DishFactory
{
    public abstract IDish CreateDish();
}



public class ChickenSaladFactory : DishFactory
{
    public override IAppetizer CreateDish()
    {
        return new ChickenSalad("Small", "350-450", 08.99m, new() { "Chicken", "Lettuce", "Tomatoes", "Cucumbers", "Salad dressing" });
    }
}
public class ButterCrackerFactory : DishFactory
{
    public override IAppetizer CreateDish()
    {
        return new ButterCracker("Small", "70-80", 09.99m, new() { "Flour", "Butter", "Salt" });
    }
}
public class CheeseTwistFactory : DishFactory
{
    public override IAppetizer CreateDish()
    {
        return new CheeseTwist("Small", "100-150", 07.99m, new() { "Puff pastry", "Cheese", "Egg", "Salt" });
    }
}
public class PotatoBiteFactory : DishFactory
{
    public override IAppetizer CreateDish()
    {
        return new PotatoBite("Small", "200-250", 05.99m, new() { "Potato", "Cheese", "Breadcrumbs", "Egg" });
    }
}


public class LasagnaFactory : DishFactory
{
    public override IMainCourse CreateDish()
    {
        return new Lasagna("Large", "300-600", 14.99m, new() { "Pasta", "Cheese", "Tomato", "Beef" });
    }
}
public class SteakFactory : DishFactory
{
    public override IMainCourse CreateDish()
    {
        return new Steak("Medium", "500-700", 17.99m, new() { "Beef steak", "Salt", "Pepper" });
    }
}
public class MolokhiyaFactory : DishFactory
{
    public override IMainCourse CreateDish()
    {
        return new Molokhiya("Medium", "100-200", 16.99m, new() { "Molokhiya leaves", "Chicken broth", "Garlic", "Coriander" });
    }
}
public class GrilledChickenFactory : DishFactory
{
    public override IMainCourse CreateDish()
    {
        return new GrilledChicken("Large", "200-300", 15.99m, new() { "Chicken", "Salt", "Pepper", "Paprika" });
    }
}


public class FruitSaladFactory : DishFactory
{
    public override IDessert CreateDish()
    {
        return new FruitSalad("Medium", "100-150", 07.99m, new() { "Apple", "Banana", "Orange", "Berries" });
    }
}
public class TiramisuFactory : DishFactory
{
    public override IDessert CreateDish()
    {
        return new Tiramisu("Small", "400-600", 08.99m, new() { "Ladyfingers", "Coffee", "Egg yolks", "Mascarpone cheese", "Cocoa powder" });
    }
}
public class BrownyFactory : DishFactory
{
    public override IDessert CreateDish()
    {
        return new Browny("Medium", "150-250", 07.99m, new() { "Sugar", "Butter", "Cocoa powder", "Eggs", "Flour", "Vanilla extract" });
    }
}
public class IceCreamFactory : DishFactory
{
    public override IDessert CreateDish()
    {
        return new IceCream("Small", "200-250", 06.99m, new() { "Milk", "Sugar", "Cream", "Egg yolks", "Vanilla extract" });
    }
}