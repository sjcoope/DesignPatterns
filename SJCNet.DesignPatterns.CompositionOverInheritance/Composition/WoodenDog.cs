using SJCNet.DesignPatterns.CompositionOverInheritance.Composition.Behaviours;
using SJCNet.DesignPatterns.Shared.Utility.Old;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Composition
{
    public class WoodenDog : Dog
    {
        public WoodenDog(string name) : base(name)
        {
            base.BarkBehaviour = new MuteBehaviour();
            base.MoveBehaviour = new NoWalkBehaviour();
        }

        public override void Display()
        {
            Logger.Write($"Hello, my name is {Name} and I am a Wooden Dog");
        }
    }
}
