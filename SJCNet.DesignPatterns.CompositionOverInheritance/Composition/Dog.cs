using SJCNet.DesignPatterns.CompositionOverInheritance.Composition.Behaviours;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Composition
{
    public abstract class Dog
    {
        protected Dog(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        protected IMoveBehaviour MoveBehaviour { get; set; }

        protected IBarkBehaviour BarkBehaviour { get; set; }

        public abstract void Display();

        public void Bark()
        {
            this.BarkBehaviour.Bark();
        }

        public void Move()
        {
            this.MoveBehaviour.Move();
        }
    }
}
