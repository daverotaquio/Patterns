using Patterns.Factory.Pizzas.Base;

namespace Patterns.Factory.Factories.Base
{
    public interface IPizzeriaFactory
    {
        void Order(IPizzaFactory pizza);
    }
}