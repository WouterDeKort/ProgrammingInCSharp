using Startup;

namespace Chapter2
{
    internal class Program
    {
        private static void Main()
        {
            Starter.Run(typeof (Program).Assembly);
        }
    }
}