using System.Collections.Generic;
using SJCNet.DesignPatterns.Decorator.Inheritance.Toppings;

namespace SJCNet.DesignPatterns.Decorator.Inheritance.Pizzas
{
    public abstract class Pizza
    {
        public Pizza()
        {
            this.Toppings = new List<ITopping>();
        }

        public virtual string Description
        {
            get
            {
                var description = "";
                foreach (var topping in this.Toppings)
                {
                    description += $"{topping.Description}, ";
                }
                return description;
            }
        }

        public List<ITopping> Toppings { get; set; }

        public virtual decimal Cost
        {
            get
            {
                var cost = 0.00m;
                foreach (var topping in this.Toppings)
                {
                    cost += topping.Cost;
                }
                return cost;
            }
        }
    }
}
