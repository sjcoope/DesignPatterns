using SJCNet.DesignPatterns.Shared.Utility;
using static System.Console;

namespace SJCNet.DesignPatterns.Output
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.WriteStart("Started");

            // Example: Composition over inheritance
            //var compositionOverInheritanceExample = new CompositionOverInheritance.Example();
            //compositionOverInheritanceExample.Execute();

            // Example: Decorator Pattern
            var decoratorPattern = new Decorator.Example();
            decoratorPattern.Execute();

            Logger.WriteEnd("Ended");
            ReadLine();
        }
    }
}
