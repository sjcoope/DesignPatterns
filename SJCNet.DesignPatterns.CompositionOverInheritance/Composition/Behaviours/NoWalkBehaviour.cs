using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Composition.Behaviours
{
    public class NoWalkBehaviour : IMoveBehaviour
    {
        public void Move()
        {
            Logger.Write("I am NOT walking");
        }
    }
}
