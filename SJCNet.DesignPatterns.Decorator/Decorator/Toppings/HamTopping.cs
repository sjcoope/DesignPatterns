using SJCNet.DesignPatterns.Decorator.Decorator.Pizzas;
using SJCNet.DesignPatterns.Decorator.Inheritance.Toppings;

namespace SJCNet.DesignPatterns.Decorator.Decorator.Toppings
{
    public class HamTopping : Pizza
    {
        private readonly Pizza _pizza;

        public HamTopping(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Description => _pizza.Description + ", Ham";

        public override decimal Cost => _pizza.Cost + 2.15m;
    }
}
