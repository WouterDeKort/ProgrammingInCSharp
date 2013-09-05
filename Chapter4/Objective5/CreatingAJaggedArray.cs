using System.ComponentModel;
using Startup;

namespace Chapter4.Objective5
{
    [Description("Listing 4-82 Creating a jagged array.")]
    internal class CreatingAJaggedArray : ISample
    {
        public void Run()
        {
            int[][] jaggedArray =
            {
                new[] {1, 3, 5, 7, 9},
                new[] {0, 2, 4, 6},
                new[] {42, 21}
            };
        }
    }
}