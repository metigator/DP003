namespace Metigator.DesignPattern.SimpleFactory
{
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
                        meal.Appetizer = DishFactory.CreateAppetizer("ChickenSalad");
                        break;
                    case 2:
                        meal.Appetizer = DishFactory.CreateAppetizer("ButterCracker");
                        break;
                    case 3:
                        meal.Appetizer = DishFactory.CreateAppetizer("CheeseTwist");
                        break;
                    case 4:
                        meal.Appetizer = DishFactory.CreateAppetizer("PotatoBite");
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
                        meal.MainCourse = DishFactory.CreateMainCourse("Lasagna");
                        break;
                    case 6:
                        meal.MainCourse = DishFactory.CreateMainCourse("Steak");
                        break;
                    case 7:
                        meal.MainCourse = DishFactory.CreateMainCourse("Molokhiya");
                        break;
                    case 8:
                        meal.MainCourse = DishFactory.CreateMainCourse("GrilledChicken");
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
                        meal.Dessert = DishFactory.CreateDessert("FruitSalad");
                        break;
                    case 10:
                        meal.Dessert = DishFactory.CreateDessert("Tiramisu");
                        break;
                    case 11:
                        meal.Dessert = DishFactory.CreateDessert("Browny");
                        break;
                    case 12:
                        meal.Dessert = DishFactory.CreateDessert("IceCream");
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
}
