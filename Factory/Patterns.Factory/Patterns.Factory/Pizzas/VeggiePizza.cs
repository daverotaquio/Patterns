using System;
using Patterns.Factory.Constants;
using Patterns.Factory.Pizzas.Base;
using Patterns.Factory.Pizzerias.Base;

namespace Patterns.Factory.Pizzas
{
    public class VeggiePizza : IPizzaFactory
    {
        private readonly IPizzeria _pizzeria;

        public VeggiePizza(IPizzeria pizzeria)
        {
            _pizzeria = pizzeria;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {_pizzeria.PizzeriaName()} Style Veggie using");
            Console.WriteLine($"Dough: {_pizzeria.Dough()}, Sauce: {_pizzeria.Sauce()}, Veggies: {_pizzeria.Veggies()}");
        }

        public void Bake()
        {
            Console.WriteLine(Steps.Bake);
        }

        public void Cut()
        {
            Console.WriteLine(Steps.Cut);
        }

        public void Box()
        {
            Console.WriteLine($"Putting pizza in {_pizzeria.BoxColor()} colored box");
        }
    }
}