using SJCNet.DesignPatterns.CompositionOverInheritance.Old.Composition.Behaviours;
using SJCNet.DesignPatterns.Shared.Utility.Old;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Old.Composition
{
    public class ElectronicDog : Dog
    {
        public ElectronicDog(string name) : base(name)
        {
            base.BarkBehaviour = new YipBehaviour();
            base.MoveBehaviour = new NoWalkBehaviour();
        }

        public override void Display()
        {
            Logger.Write($"Hello, my name is {Name} and I am an Electronic Dog");
        }
    }
}
