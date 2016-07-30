namespace SJCNet.DesignPatterns.Decorator.Inheritance.Pizzas
{
    public class DeepPanPizza : Pizza
    {
        public override string Description => "Deep Pan Pizza, " + base.Description;

        public override decimal Cost => base.Cost + 2.10m;
    }
}
