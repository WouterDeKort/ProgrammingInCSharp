using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-2 Creating a custom struct.")]
    internal class CreatingACustomStruct : ISample
    {
        public void Run()
        {
            var p = new Point {x = 42, y = 84};
        }

        public struct Point
        {
            public int x, y;

            public Point(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }
    }
}