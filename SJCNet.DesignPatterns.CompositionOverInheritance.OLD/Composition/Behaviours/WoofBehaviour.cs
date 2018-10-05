using SJCNet.DesignPatterns.Shared.Utility.Old;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Old.Composition.Behaviours
{
    public class WoofBehaviour : IBarkBehaviour
    {
        public void Bark()
        {
            Logger.Write($"I am woofing");
        }
    }
}
