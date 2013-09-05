using System;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective5
{
    [Description("Listing 4-81 Using a two-dimensional array.")]
    internal class UsingATwoDimensionalArray : ISample
    {
        public void Run()
        {
            var array2D = new string[3, 2]
            {
                {"one", "two"}, {"three", "four"},
                {"five", "six"}
            };

            Console.WriteLine(array2D[0, 0]); // one
            Console.WriteLine(array2D[0, 1]); // two
            Console.WriteLine(array2D[1, 0]); // three
            Console.WriteLine(array2D[1, 1]); // four
            Console.WriteLine(array2D[2, 0]); // five
            Console.WriteLine(array2D[2, 1]); // six        }
        }
    }
}