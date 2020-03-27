using System;
using System.Threading;
using Patterns.Factory.Factories.Base;
using Patterns.Factory.Pizzas;
using Patterns.Factory.Pizzas.Base;
using Patterns.Factory.Pizzerias;

namespace Patterns.Factory.Factories
{
    public class PizzeriaFactory : IPizzeriaFactory
    {
        public void Order(IPizzaFactory pizza)
        {
            pizza.Prepare();
            Thread.Sleep(3000);
            pizza.Bake();
            Thread.Sleep(3000);
            pizza.Cut();
            Thread.Sleep(3000);
            pizza.Box();
        }
    }
}