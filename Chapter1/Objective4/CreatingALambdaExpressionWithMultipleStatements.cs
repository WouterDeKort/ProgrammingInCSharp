using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-80 Creating a lambda expression with multiple statements.")]
    internal class CreatingALambdaExpressionWithMultipleStatements : ISample
    {
        public delegate int Calculate(int x, int y);

        public void Run()
        {
            Calculate calc =
                (x, y) =>
                {
                    Console.WriteLine("Adding numbers");
                    return x + y;
                };

            int result = calc(3, 4);

            Console.WriteLine(result);
        }
    }
}