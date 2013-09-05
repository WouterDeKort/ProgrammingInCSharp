using System.ComponentModel;
using System.Text;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-87  Changing a character with a StringBuilder.")]
    internal class ChangingACharacterWithAStringBuilder : ISample
    {
        public void Run()
        {
            var sb = new StringBuilder("A initial value");
            sb[0] = 'B';
        }
    }
}