using SJCNet.DesignPatterns.Shared.Utility.Old;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Composition.Behaviours
{
    public class WalkBehaviour : IMoveBehaviour
    {
        public void Move()
        {
            Logger.Write("I am walking");
        }
    }
}
