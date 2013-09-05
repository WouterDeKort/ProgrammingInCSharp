using System;
using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-55 Syntactic sugar of the foreach statement.")]
    internal class SyntacticSugarOfTheForeachStatement : ISample
    {
        public void Run()
        {
            var numbers = new List<int> {1, 2, 3, 5, 7, 9};
            using (List<int>.Enumerator enumerator = numbers.GetEnumerator())
            {
                while (enumerator.MoveNext()) Console.WriteLine(enumerator.Current);
            }
        }
    }
}