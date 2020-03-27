using System;
using System.Collections.Generic;
using System.Text;
using Patterns.Factory.Constants;
using Patterns.Factory.Pizzas.Base;
using Patterns.Factory.Pizzerias.Base;

namespace Patterns.Factory.Pizzas
{
    public class ClamPizza : IPizzaFactory
    {
        private readonly IPizzeria _pizzeria;

        public ClamPizza(IPizzeria pizzeria)
        {
            _pizzeria = pizzeria;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {_pizzeria.PizzeriaName()} Style Clam using");
            Console.WriteLine($"Dough: {_pizzeria.Dough()}, Clam: {_pizzeria.Clam()}, Sauce: {_pizzeria.Sauce()}, Cheese: {_pizzeria.Cheese()}");
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
