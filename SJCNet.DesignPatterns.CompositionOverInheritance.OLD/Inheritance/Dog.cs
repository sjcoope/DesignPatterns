using SJCNet.DesignPatterns.Shared.Utility.Old;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Old.Inheritance
{
    public abstract class Dog
    {
        protected Dog(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public abstract void Display();

        public void Move()
        {
            Logger.Write("I am walking");
        }

        public void Bark()
        {
            Logger.Write("I am woofing");
        }
    }
}
