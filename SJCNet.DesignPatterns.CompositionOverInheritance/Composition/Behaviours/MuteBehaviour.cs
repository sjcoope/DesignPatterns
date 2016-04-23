using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Composition.Behaviours
{
    public class MuteBehaviour : IBarkBehaviour
    {
        public void Bark()
        {
            Logger.Write($"I am mute");
        }
    }
}
