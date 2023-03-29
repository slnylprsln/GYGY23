
namespace SOLID
{
    public class DrinkFactory
    {
        public static IDrinkRepository Create()
        {
            return new DrinkRepository();
        }
    }
}
