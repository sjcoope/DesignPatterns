namespace SJCNet.DesignPatterns.Decorator.Inheritance.Toppings
{
    public class ChillieTopping : ITopping
    {
        public string Description => "Chillies";

        public decimal Cost => 1.15m;
    }
}
