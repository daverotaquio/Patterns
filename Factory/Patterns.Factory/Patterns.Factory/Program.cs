using System;
using Patterns.Factory.Factories;
using Patterns.Factory.Factories.Base;
using Patterns.Factory.Pizzas;
using Patterns.Factory.Pizzerias;

namespace Patterns.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzeriaFactory pizzeriaFactory = new PizzeriaFactory();

            // change class according to your desired order
            pizzeriaFactory.Order(new CheesePizza(new PizzeriaA()));

            Console.ReadLine();
        }
    }
}
