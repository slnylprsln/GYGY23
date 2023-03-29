
namespace SOLID
{
    public interface IDrink
    {
        public void ShowDrinks();
        public void Caution(IHotBeverage hotBeverage);
        public void Pour(int amount);
        public void Sell();
    }
}
