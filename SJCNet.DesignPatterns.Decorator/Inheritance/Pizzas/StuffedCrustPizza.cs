namespace SJCNet.DesignPatterns.Decorator.Inheritance.Pizzas
{
    public class StuffedCrustPizza : Pizza
    {
        public override string Description => "Stuffed Crust Pizza, " + base.Description;
        
        public override decimal Cost => base.Cost + 3.50m;
    }
}
