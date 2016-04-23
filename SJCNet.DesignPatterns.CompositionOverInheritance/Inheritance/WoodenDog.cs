using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Inheritance
{
    public class WoodenDog : Dog
    {
        public WoodenDog(string name) : base(name)
        {}

        public override void Display()
        {
            Logger.Write($"Hello, my name is {Name} and I am a Wooden Dog");
        }
    }
}
