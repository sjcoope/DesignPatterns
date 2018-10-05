using SJCNet.DesignPatterns.CompositionOverInheritance.Composition.Behaviours;
using SJCNet.DesignPatterns.Shared.Utility.Old;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Composition
{
    public class LabradorDog : Dog
    {
        public LabradorDog(string name) : base(name)
        {
            base.BarkBehaviour = new WoofBehaviour();
            base.MoveBehaviour = new WalkBehaviour();
        }

        public override void Display()
        {
            Logger.Write($"Hello, my name is {Name} and I am a Labrador");
        }
    }
}
