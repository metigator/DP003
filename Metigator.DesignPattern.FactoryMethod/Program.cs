namespace Metigator.DesignPattern.FactoryMethod
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
                        meal.Appetizer = new ChickenSaladFactory().CreateDish();
                        break;
                    case 2:
                        meal.Appetizer = new ButterCrackerFactory().CreateDish();
                        break;
                    case 3:
                        meal.Appetizer = new CheeseTwistFactory().CreateDish();
                        break;
                    case 4:
                        meal.Appetizer = new PotatoBiteFactory().CreateDish();
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
                        meal.MainCourse = new LasagnaFactory().CreateDish();
                        break;
                    case 6:
                        meal.MainCourse = new SteakFactory().CreateDish();
                        break;
                    case 7:
                        meal.MainCourse = new MolokhiyaFactory().CreateDish();
                        break;
                    case 8:
                        meal.MainCourse = new GrilledChickenFactory().CreateDish();
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
                        meal.Dessert = new FruitSaladFactory().CreateDish();
                        break;
                    case 10:
                        meal.Dessert = new TiramisuFactory().CreateDish();
                        break;
                    case 11:
                        meal.Dessert = new BrownyFactory().CreateDish();
                        break;
                    case 12:
                        meal.Dessert = new IceCreamFactory().CreateDish();
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
