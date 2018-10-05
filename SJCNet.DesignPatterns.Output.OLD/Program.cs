using SJCNet.DesignPatterns.Shared.Utility.Old;
using static System.Console;

namespace SJCNet.DesignPatterns.Output.Old
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.WriteStart("Started");

            // Example: Composition over inheritance
            //var compositionOverInheritanceExample = new CompositionOverInheritance.Example();
            //compositionOverInheritanceExample.Execute();

            // Example: Observer Pattern
            //var observerPattern = new Observer.Example();
            //observerPattern.Execute();

            // Example: Factory Pattern
            //var factoryPattern = new Factory.Example();
            //factoryPattern.Execute();

            Logger.WriteEnd("Ended");
            ReadLine();
        }
    }
}
