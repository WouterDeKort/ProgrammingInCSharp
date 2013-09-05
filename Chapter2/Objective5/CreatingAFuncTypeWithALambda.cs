using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-77 Creating a Func type with a lambda.")]
    internal class CreatingAFuncTypeWithALambda : ISample

    {
        public void Run()
        {
            Func<int, int, int> addFunc = (x, y) => x + y;
            Console.WriteLine(addFunc(2, 3));
        }
    }
}