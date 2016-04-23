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
            var compositionOverInheritanceExample = new CompositionOverInheritance.Example();
            compositionOverInheritanceExample.Execute();

            Logger.WriteEnd("Ended");
            ReadLine();
        }
    }
}
