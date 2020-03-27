using System;
using System.Threading;
using Patterns.Factory.Constants;
using Patterns.Factory.Pizzas.Base;
using Patterns.Factory.Pizzerias.Base;

namespace Patterns.Factory.Pizzas
{
    public class CheesePizza : IPizzaFactory
    {
        private readonly IPizzeria _pizzeria;

        public CheesePizza(IPizzeria pizzeria)
        {
            _pizzeria = pizzeria;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {_pizzeria.PizzeriaName()} Style Cheese using");
            Console.WriteLine($"Dough: {_pizzeria.Dough()}, Cheese: {_pizzeria.Cheese()}, Sauce: {_pizzeria.Sauce()}, Veggies: {_pizzeria.Veggies()}");
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
