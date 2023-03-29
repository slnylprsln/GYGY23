
namespace SOLID
{
    public class Soda : Drink
    {
        public string Fruit { get; set; }

        public override void Pour(int amount)
        {
            Console.WriteLine(amount + " mL " + Fruit + " soda is being poured...");
        }
    }
}
