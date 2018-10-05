using System.Collections.Generic;
using SJCNet.DesignPatterns.Shared.Contracts;
using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.CompositionOverInheritance
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteHeader("Composition Over Inheritance");

            Logger.WriteSubHeader("Inheritance Example");
            var inheritedDogs = new List<Inheritance.Dog>()
            {
                new Inheritance.GoldenRetrieverDog("Sammy"),
                new Inheritance.LabradorDog("Ben"),
                new Inheritance.WoodenDog("Woody"),
                new Inheritance.ElectronicDog("Yippy")
            };

            inheritedDogs.ForEach(x =>
            {
                x.Display();
                x.Move();
                x.Bark();
            });

            Logger.WriteSubHeader("Composition Example");
            var composedDogs = new List<Composition.Dog>()
            {
                new Composition.GoldenRetrieverDog("Sammy"),
                new Composition.LabradorDog("Ben"),
                new Composition.WoodenDog("Woody"),
                new Composition.ElectronicDog("Yippy")
            };

            composedDogs.ForEach(x =>
            {
                x.Display();
                x.Bark();
                x.Move();
            });
        }
    }
}
