
using SOLID;

Tea Tea = new Tea();
Tea.Flavor = "raspberry";
Tea.SugarOrNot = false;

Tea.Pour(200);

Drink drink = new();
drink.ShowDrinks();