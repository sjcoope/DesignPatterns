namespace SJCNet.DesignPatterns.Decorator.Decorator.Pizzas
{
    public class StuffedCrustPizza : Pizza
    {
        public override string Description => "Stuffed Crust Pizza";
        
        public override decimal Cost => 3.50m;
    }
}
