namespace SJCNet.DesignPatterns.Decorator.Inheritance.Pizzas
{
    public class StoneBakedPizza : Pizza
    {
        public override string Description => "Stone Baked Pizza, " + base.Description;

        public override decimal Cost => base.Cost + 1.50m;
    }
}
