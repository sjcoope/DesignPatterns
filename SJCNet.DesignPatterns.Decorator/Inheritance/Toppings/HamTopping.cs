namespace SJCNet.DesignPatterns.Decorator.Inheritance.Toppings
{
    public class HamTopping : ITopping
    {
        public string Description => "Ham";

        public decimal Cost => 2.15m;
    }
}
