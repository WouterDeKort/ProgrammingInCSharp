using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-50 A Rectangle class with an Area calculation.")]
    internal class ARectangleClassWithAnAreaCalculation : ISample
    {
        public void Run()
        {
        }

        private class Rectangle
        {
            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public int Height { get; set; }

            public int Width { get; set; }

            public int Area
            {
                get { return Height*Width; }
            }
        }
    }
}