using Startup;

namespace Chapter1
{
    internal class Program
    {
        private static void Main()
        {
            Starter.Run(typeof (Program).Assembly);
        }
    }
}