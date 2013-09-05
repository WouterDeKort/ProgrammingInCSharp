using Startup;

namespace Chapter4
{
    internal class Program
    {
        private static void Main()
        {
            Starter.Run(typeof (Program).Assembly);
        }
    }
}