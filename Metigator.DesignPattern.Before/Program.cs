namespace Metigator.DesignPattern.Before;

class Program
{
    public static void Main(string[] args)
    {
        (IAppetizer Appetizer, IMainCourse MainCourse, IDessert Dessert) meal = new();

        int choice;

        Console.WriteLine("Appetizers");
        Console.WriteLine($" ├ [01] Chicken Salad");
        Console.WriteLine($" ├ [02] Butter Cracker");
        Console.WriteLine($" ├ [03] Cheese Twist");
        Console.WriteLine($" ├ [04] Potato Bite");
        Console.WriteLine($" └ Any other key to skip");


        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    meal.Appetizer = new ChickenSalad("Small", "350-450", 08.99m, new() { "Chicken", "Lettuce", "Tomatoes", "Cucumbers", "Salad dressing" });
                    break;
                case 2:
                    meal.Appetizer = new ButterCracker("Small", "70-80", 09.99m, new() { "Flour", "Butter", "Salt" });
                    break;
                case 3:
                    meal.Appetizer = new CheeseTwist("Small", "100-150", 07.99m, new() { "Puff pastry", "Cheese", "Egg", "Salt" });
                    break;
                case 4:
                    meal.Appetizer = new PotatoBite("Small", "200-250", 05.99m, new() { "Potato", "Cheese", "Breadcrumbs", "Egg" });
                    break;
                default:
                    break;
            }
        }

        Console.Clear();

        Console.WriteLine("Main Course");
        Console.WriteLine($" ├ [05] Lasagna");
        Console.WriteLine($" ├ [06] Steak");
        Console.WriteLine($" ├ [07] Molokhiya");
        Console.WriteLine($" ├ [08] Grilled Chicken");
        Console.WriteLine($" └ Any other key to skip");

        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 5:
                    meal.MainCourse = new Lasagna("Large", "300-600", 14.99m, new() { "Pasta", "Cheese", "Tomato", "Beef" });
                    break;
                case 6:
                    meal.MainCourse = new Steak("Medium", "500-700", 17.99m, new() { "Beef steak", "Salt", "Pepper" });
                    break;
                case 7:
                    meal.MainCourse = new Molokhiya("Medium", "100-200", 16.99m, new() { "Molokhiya leaves", "Chicken broth", "Garlic", "Coriander" });
                    break;
                case 8:
                    meal.MainCourse = new GrilledChicken("Large", "200-300", 15.99m, new() { "Chicken", "Salt", "Pepper", "Paprika" });
                    break;
                default:
                    break;
            }
        }

        Console.Clear();

        Console.WriteLine("Desserts");
        Console.WriteLine($" ├ [09] Fruit Salad");
        Console.WriteLine($" ├ [10] Tiramisu");
        Console.WriteLine($" ├ [11] Browny");
        Console.WriteLine($" ├ [12] IceCream");
        Console.WriteLine($" └ Any other key to skip");


        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 9:
                    meal.Dessert = new FruitSalad("Medium", "100-150", 07.99m, new() { "Apple", "Banana", "Orange", "Berries" });
                    break;
                case 10:
                    meal.Dessert = new Tiramisu("Small", "400-600", 08.99m, new() { "Ladyfingers", "Coffee", "Egg yolks", "Mascarpone cheese", "Cocoa powder" });
                    break;
                case 11:
                    meal.Dessert = new Browny("Medium", "150-250", 07.99m, new() { "Sugar", "Butter", "Cocoa powder", "Eggs", "Flour", "Vanilla extract" });
                    break;
                case 12:
                    meal.Dessert = new IceCream("Small", "200-250", 06.99m, new() { "Milk", "Sugar", "Cream", "Egg yolks", "Vanilla extract" });
                    break;
                default:
                    break;
            }
        }
        Console.Clear();

        meal.Appetizer?.Serve();
        meal.MainCourse?.Serve();
        meal.Dessert?.Serve();
    }
}





