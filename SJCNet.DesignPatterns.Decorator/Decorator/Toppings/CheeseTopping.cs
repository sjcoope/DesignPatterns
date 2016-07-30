using SJCNet.DesignPatterns.Decorator.Decorator.Pizzas;

namespace SJCNet.DesignPatterns.Decorator.Decorator.Toppings
{
    public class CheeseTopping : ToppingDecorator
    {
        private readonly Pizza _pizza;

        public CheeseTopping(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Description => _pizza.Description + ", Cheese";

        public override decimal Cost => _pizza.Cost + 0.80m;
    }
}
