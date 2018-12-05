using SJCNet.DesignPatterns.Shared.Contracts;
using SJCNet.DesignPatterns.Shared.Utility;
using System.Threading.Tasks;

namespace SJCNet.DesignPatterns.Singleton
{
    public class Example : IExample
    {
        public void Execute()
        {
            //ExecuteNonSingletonWithSingleThread();
            //ExecuteNonSingletonWithMultipleThreads();
            //ExecuteSingleton1WithMultipleThreads();
            ExecuteSingleton2WithMultipleThreads();
        }

        private void ExecuteNonSingletonWithSingleThread()
        {
            Logger.AddLineBreak();
            Logger.WriteSubHeader("Starting NonSingletone with Single Thread");

            MakeTea(new NonSingleton());
        }

        private void ExecuteNonSingletonWithMultipleThreads()
        {
            Logger.AddLineBreak();
            Logger.WriteSubHeader("Starting NonSingleton with Multiple Threads...");

            var task1 = Task.Run(() => MakeTea(new NonSingleton()));
            var task2 = Task.Run(() => MakeTeaWithDelay(new NonSingleton()));
            Task.WaitAll(task1, task2);
        }
 
        private void ExecuteSingleton1WithMultipleThreads()
        {
            Logger.AddLineBreak();
            Logger.WriteSubHeader("Starting Singleton1 with Multiple Threads");

            var task1 = Task.Run(() => MakeTea(Singleton1.Instance));
            var task2 = Task.Run(() => MakeTea(Singleton1.Instance));
            Task.WaitAll(task1, task2);
        }

        private void ExecuteSingleton2WithMultipleThreads()
        {
            Logger.AddLineBreak();
            Logger.WriteSubHeader("Starting Singleton2 with Multiple Threads");

            var task1 = Task.Run(() => MakeTea(Singleton2.Instance));
            var task2 = Task.Run(() => MakeTeaWithDelay(Singleton2.Instance));
            Task.WaitAll(task1, task2);
        }

        private void MakeTeaWithDelay(ITeaMaker teaMaker)
        {
            System.Threading.Thread.Sleep(5);
            MakeTea(teaMaker);
        }

        private void MakeTea(ITeaMaker teaMaker)
        {
            teaMaker.FillKettle();
            teaMaker.BoilKettle();
            teaMaker.PutTeaBagInCup();
            teaMaker.FillCup();
            //teaMaker.RemoveTeaBagFromCup();
        }
    }
}
