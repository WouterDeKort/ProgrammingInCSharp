using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective2
{
    [Description("Listing 1-39 A potential problem with multithreaded code.")]
    internal class APotentialProblemWithMultithreadedCode : ISample
    {
        private static int _flag;
        private static int _value;

        public void Run()
        {
            Task.Run(() => Thread1());
            Task.Run(() => Thread2());
        }

        public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }

        public static void Thread2()
        {
            if (_flag == 1)
                Console.WriteLine(_value);
        }
    }
}