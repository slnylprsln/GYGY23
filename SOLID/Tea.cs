
namespace SOLID
{
    public class Tea : Drink, IHotBeverage, ISugarAddable
    {
        public string Flavor { get; set; }
        public bool SugarOrNot { get; set; }

        public void AddSugar()
        {
            Console.WriteLine("Extra sugar is added to your tea!");
        }

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
