using System.Collections.Generic;
using SJCNet.DesignPatterns.Decorator.Inheritance;
using SJCNet.DesignPatterns.Shared.Contracts;
using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.Decorator
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteHeader("Decorator Pattern");

            Logger.WriteSubHeader("Inheritance Example");

            var inheritancePizza = new Inheritance.Pizzas.DeepPanPizza();
            inheritancePizza.Toppings.Add(new Inheritance.Toppings.CheeseTopping());
            inheritancePizza.Toppings.Add(new Inheritance.Toppings.PepperoniTopping());
            inheritancePizza.Toppings.Add(new Inheritance.Toppings.HamTopping());
            Logger.Write($"Description: {inheritancePizza.Description} for £{inheritancePizza.Cost}");
            
            Logger.WriteSubHeader("Decorator Example");
            var decoratorPizza = new Decorator.Pizzas.DeepPanPizza();
            var cheeseTopping = new Decorator.Toppings.CheeseTopping(decoratorPizza);
            var pepperoniTopping = new Decorator.Toppings.PepperoniTopping(cheeseTopping);
            var hamTopping = new Decorator.Toppings.HamTopping(pepperoniTopping);
            Logger.Write($"Description: {hamTopping.Description} for £{hamTopping.Cost}");
        }
    }
}
