using Startup;

namespace Chapter3
{
    internal class Program
    {
        private static void Main()
        {
            Starter.Run(typeof (Program).Assembly);
        }
    }
}