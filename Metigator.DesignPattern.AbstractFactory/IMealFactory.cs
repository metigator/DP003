namespace Metigator.DesignPattern.AbstractFactory
{
    internal interface IMealFactory
    {
        IAppetizer PrepareAppetizer();
        IMainCourse PrepareMainCourse();
        IDessert PrepareDessert();
    }

    public class SpecialComboFactory : IMealFactory
    {
        public IAppetizer PrepareAppetizer()
        {
            return new PotatoBite("Small", "200-250", 05.99m, new() { "Potato", "Cheese", "Breadcrumbs", "Egg" });
        }

        public IMainCourse PrepareMainCourse()
        {
            return new Lasagna("Large", "300-600", 14.99m, new() { "Pasta", "Cheese", "Tomato", "Beef" });
        }

        public IDessert PrepareDessert()
        {
            return new Tiramisu("Small", "400-600", 08.99m, new() { "Ladyfingers", "Coffee", "Egg yolks", "Mascarpone cheese", "Cocoa powder" });
        }
    }

    public class DietMealFactory : IMealFactory
    {
        public IAppetizer PrepareAppetizer()
        {
            return new ChickenSalad("Small", "350-450", 08.99m, new() { "Chicken", "Lettuce", "Tomatoes", "Cucumbers", "Salad dressing" });
        }

        public IMainCourse PrepareMainCourse()
        {
            return new GrilledChicken("Large", "200-300", 15.99m, new() { "Chicken", "Salt", "Pepper", "Paprika" });

        }

        public IDessert PrepareDessert()
        {
            return new FruitSalad("Medium", "100-150", 07.99m, new() { "Apple", "Banana", "Orange", "Berries" });
        }
    }
}
