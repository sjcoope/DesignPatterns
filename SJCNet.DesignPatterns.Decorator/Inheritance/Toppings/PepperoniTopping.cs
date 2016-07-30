namespace SJCNet.DesignPatterns.Decorator.Inheritance.Toppings
{
    public class PepperoniTopping : ITopping
    {
        public string Description => "Pepperoni";

        public decimal Cost => 1.90m;
    }
}
