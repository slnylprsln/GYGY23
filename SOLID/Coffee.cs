namespace SOLID
{
    public class Coffee : Drink, IHotBeverage
    {
        public bool SugarOrNot { get; set; }
        public bool MilkOrNot { get; set; }
        public CoffeeIntensity CoffeeIntensity { get; set; }

        public bool isHotBeverage()
        {
            return true;
        }

        public override void Pour(int amount)
        {
            Console.WriteLine(amount + " mL coffee is being poured...");
        }
    }

    public enum CoffeeIntensity
    {
        Light,
        Medium,
        Dark
    }
}
