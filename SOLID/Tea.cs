namespace SOLID
{
    public class Tea : Drink
    {
        public string Flavor { get; set; }
        public bool SugarOrNot { get; set; }


        public override void Pour(int amount)
        {
            Console.WriteLine(amount + " mL " + Flavor + " tea is being poured...");
        }
    }
}
