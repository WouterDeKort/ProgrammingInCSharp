using System.ComponentModel;
using Startup;

namespace Chapter2.Objective3
{
    [Description("Listing 2-40 Implementing an interface explicitly.")]
    internal class ImplementingAnInterfaceExplicitlyII : ISample
    {
        public void Run()
        {
        }

        private interface ILeft
        {
            void Move();
        }

        private interface IRight
        {
            void Move();
        }

        private class MoveableOject : ILeft, IRight
        {
            void ILeft.Move()
            {
            }

            void IRight.Move()
            {
            }
        }
    }
}