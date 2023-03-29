
namespace SOLID
{
    public class Tea : Drink, IHotBeverage
    {
        public string Flavor { get; set; }
        public bool SugarOrNot { get; set; }

        public bool isHotBeverage()
        {
            return true;
        }

        public override void Pour(int amount)
        {
            Console.WriteLine(amount + " mL " + Flavor + " tea is being poured...");
        }
    }
}
