using Patterns.Factory.Constants;
using Patterns.Factory.Pizzerias.Base;

namespace Patterns.Factory.Pizzerias
{
    public class PizzeriaB : IPizzeria
    {
        public string PizzeriaName() => "Pizzeria B";
        public string Cheese() => Ingredients.Parmesan;
        public string Clam() => Ingredients.FreshClam;
        public string Dough() => Ingredients.DeepDish;
        public string Sauce() => Ingredients.PlumTomato;
        public string Veggies() => string.Join(", ", Ingredients.Cucumber, Ingredients.Onions, Ingredients.BellPeppers);
        public string BoxColor() => Color.Green;
    }
}