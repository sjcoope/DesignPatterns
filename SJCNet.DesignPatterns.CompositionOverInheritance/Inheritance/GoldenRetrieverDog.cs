using SJCNet.DesignPatterns.Shared.Utility.Old;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Inheritance
{
    public class GoldenRetrieverDog : Dog
    {
        public GoldenRetrieverDog(string name) : base(name)
        {}

        public override void Display()
        {
            Logger.Write($"Hello, my name is {Name} and I am a Golden Retriever");
        }
    }
}
