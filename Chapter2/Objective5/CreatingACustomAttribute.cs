using System.ComponentModel;
using Startup;
using Xunit;

namespace Chapter2.Objective5
{
    [Description("Listing 2-64 Creating a custom attribute.")]
    internal class CreatingACustomAttribute : ISample
    {
        public void Run()
        {
        }

        public class CategoryAttribute : TraitAttribute
        {
            public CategoryAttribute(string value)
                : base("Category", value)
            {
            }
        }

        public class UnitTestAttribute : CategoryAttribute
        {
            public UnitTestAttribute()
                : base("Unit Test")
            {
            }
        }
    }
}