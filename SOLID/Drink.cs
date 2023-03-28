namespace SOLID
{
    public class Drink
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Heat Heat { get; set; }
        public bool IsInStock { get; set; }
        public DrinkEvaluation DrinkEvaluation;

        public Drink()
        {
            DrinkEvaluation = new DrinkEvaluation();
        }

        public virtual void Pour(int amount)
        {
            Console.WriteLine(amount + " mL drink is being poured...");
        }

        public virtual void Sell()
        {
            Console.WriteLine("Drink has been bought...");
        }

        public void Evaluate()
        {
            DrinkEvaluation.Evaluate();
        }

        public void Comment()
        {
            DrinkEvaluation.Comment();
        }

    }

    public enum Heat
    {
        Hot,
        Cold
    }
}
