
namespace SOLID
{
    public class Drink : IDrink, IDrinkEvaluation
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsInStock { get; set; }

        public DrinkEvaluation DrinkEvaluation;

        public Drink()
        {
            DrinkEvaluation = new DrinkEvaluation();
        }

        public void ShowDrinks()
        {
            IDrinkRepository drinkRepository = DrinkFactory.Create();
            List<Drink> allDrinks = drinkRepository.GetAllDrinks();
            Console.WriteLine("Here is the drinks:");
            foreach (Drink drink in allDrinks)
            {
                Console.WriteLine(drink.Name);
            }
        }

        public void Caution(IHotBeverage hotBeverage)
        {
            if (hotBeverage.isHotBeverage())
            {
                Console.WriteLine("Be careful! Your drink is hot.");
            }
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
}
