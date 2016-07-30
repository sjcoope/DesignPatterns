using SJCNet.DesignPatterns.Decorator.Decorator.Pizzas;
using SJCNet.DesignPatterns.Decorator.Inheritance.Toppings;

namespace SJCNet.DesignPatterns.Decorator.Decorator.Toppings
{
    public class ChillieTopping : Pizza
    {
        private readonly Pizza _pizza;

        public ChillieTopping(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Description => _pizza.Description + ", Chillies";

        public override decimal Cost => _pizza.Cost + 1.15m;
    }
}
