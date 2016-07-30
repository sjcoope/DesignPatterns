namespace SJCNet.DesignPatterns.Decorator.Inheritance.Toppings
{
    public class CheeseTopping : ITopping
    {
        public string Description => "Cheese";

        public decimal Cost => 0.80m;
    }
}
