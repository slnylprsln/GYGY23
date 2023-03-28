namespace SOLID
{
    public class Coffee : Drink
    {
        public bool SugarOrNot { get; set; }
        public bool MilkOrNot { get; set; }
        public CoffeeIntensity CoffeeIntensity { get; set; }

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
