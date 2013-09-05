using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-52 Using the Square class.")]
    internal class UsingTheSquareClass : ISample
    {
        public void Run()
        {
            Rectangle rectangle = new Square();
            rectangle.Width = 10;
            rectangle.Height = 5;

            Console.WriteLine(rectangle.Area);
        }

        private class Rectangle
        {
            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public virtual int Height { get; set; }

            public virtual int Width { get; set; }

            public int Area
            {
                get { return Height*Width; }
            }
        }

        private class Square : Rectangle
        {
            public Square()
                : base(0, 0)
            {
            }

            public override int Width
            {
                get { return base.Width; }
                set
                {
                    base.Width = value;
                    base.Height = value;
                }
            }

            public override int Height
            {
                get { return base.Height; }
                set
                {
                    base.Height = value;
                    base.Width = value;
                }
            }
        }
    }
}