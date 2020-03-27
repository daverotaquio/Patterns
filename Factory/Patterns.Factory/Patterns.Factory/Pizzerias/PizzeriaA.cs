using Patterns.Factory.Constants;
using Patterns.Factory.Pizzerias.Base;

namespace Patterns.Factory.Pizzerias
{
    public class PizzeriaA : IPizzeria
    {
        public string PizzeriaName() => "Pizzeria A";
        public string Cheese() => Ingredients.Mozzarella;
        public string Clam() => Ingredients.FrozenClam;
        public string Dough() => Ingredients.ThinCrust;
        public string Sauce() => Ingredients.CherryTomato;
        public string Veggies() => string.Join(", ", Ingredients.Olives, Ingredients.Onions, Ingredients.BellPeppers);
        public string BoxColor() => Color.Red;
    }
}
