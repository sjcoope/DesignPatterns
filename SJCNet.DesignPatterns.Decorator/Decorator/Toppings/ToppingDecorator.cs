using System;
using SJCNet.DesignPatterns.Decorator.Decorator.Pizzas;

namespace SJCNet.DesignPatterns.Decorator.Decorator.Toppings
{
    public abstract class ToppingDecorator : Pizza
    {
        public abstract override string Description { get; }

        public abstract override decimal Cost { get; }
    }
}
