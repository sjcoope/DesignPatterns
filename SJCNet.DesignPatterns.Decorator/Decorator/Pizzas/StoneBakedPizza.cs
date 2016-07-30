namespace SJCNet.DesignPatterns.Decorator.Decorator.Pizzas
{
    public class StoneBakedPizza : Pizza
    {
        public override string Description => "Stone Baked Pizza";

        public override decimal Cost => .50m;
    }
}
