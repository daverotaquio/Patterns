namespace Patterns.Factory.Pizzas.Base
{
    public interface IPizzaFactory
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}