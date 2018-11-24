using SJCNet.DesignPatterns.Shared.Contracts;
using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.Singleton
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("Basic Teamaker Implementation");
            ExecuteBasicTeamakerImplementation();

            Logger.WriteSubHeader("Simple Singleton Teamaker Implementation");
            ExecuteSimpleSingletonImplementation();
        }

        private void ExecuteBasicTeamakerImplementation()
        {
            Logger.AddLineBreak();
            Logger.Write("Starting Basic Teamaker Example...");

            var teaMaker = new BasicTeaMaker();
            teaMaker.FillKettle();
            teaMaker.BoilKettle();
            teaMaker.PutTeaBagInCup();
            teaMaker.FillCup();
            teaMaker.RemoveTeaBagFromCup();
        }

        private void ExecuteSimpleSingletonImplementation()
        {
            Logger.AddLineBreak();
            Logger.Write("Starting Simple Singleton Example...");

        }
    }
}
