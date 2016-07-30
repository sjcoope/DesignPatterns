using SJCNet.DesignPatterns.Decorator.Decorator.Pizzas;

namespace SJCNet.DesignPatterns.Decorator.Decorator.Toppings
{
    public class PepperoniTopping : Pizza
    {
        private readonly Pizza _pizza;

        public PepperoniTopping(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Description => _pizza.Description + ", Pepperoni";

        public override decimal Cost => _pizza.Cost + 1.90m;
    }
}
