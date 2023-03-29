
namespace SOLID
{
    public class DrinkRepository : IDrinkRepository
    {
        public List<Drink> GetAllDrinks()
        {
            Drink tea1 = new Tea();
            tea1.Name = "Pineapple Tea";
            Drink tea2 = new Tea();
            tea2.Name = "Blueberry Tea";
            List<Drink> drinks = new();
            drinks.Add(tea1);
            drinks.Add(tea2);

            return drinks;
        }
    }
}
