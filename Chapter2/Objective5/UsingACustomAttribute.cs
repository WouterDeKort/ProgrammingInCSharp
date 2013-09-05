using System.ComponentModel;
using Startup;
using Xunit;

namespace Chapter2.Objective5
{
    [Description("Listing 2-65 Using a custom attribute.")]
    internal class UsingACustomAttribute : ISample
    {
        public void Run()
        {
        }

        [Fact]
        [UnitTest]
        public void MySecondUnitTest()
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