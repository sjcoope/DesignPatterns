using SJCNet.DesignPatterns.Shared.Utility.Old;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Old.Inheritance
{
    public class ElectronicDog : Dog
    {
        public ElectronicDog(string name) : base(name)
        {}

        public override void Display()
        {
            Logger.Write($"Hello, my name is {Name} and I am an Electronic Dog");
        }
    }
}
