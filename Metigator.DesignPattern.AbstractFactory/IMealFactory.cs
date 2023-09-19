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
            return new PotatoBiteFactory().CreateDish();
        }

        public IMainCourse PrepareMainCourse()
        {
            return new LasagnaFactory().CreateDish();
        }

        public IDessert PrepareDessert()
        {
            return new TiramisuFactory().CreateDish();  
        }
    }

    public class DietMealFactory : IMealFactory
    {
        public IAppetizer PrepareAppetizer()
        {
            return new ChickenSaladFactory().CreateDish();
        }

        public IMainCourse PrepareMainCourse()
        {
            return new GrilledChickenFactory().CreateDish();

        }

        public IDessert PrepareDessert()
        {
            return new FruitSaladFactory().CreateDish();
        }
    }
}
