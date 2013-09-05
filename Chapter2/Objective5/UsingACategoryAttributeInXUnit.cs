using System.ComponentModel;
using Startup;
using Xunit;

namespace Chapter2.Objective5
{
    [Description("Listing 2-63 Using a category attribute in xUnit.")]
    internal class UsingACategoryAttributeInXUnit : ISample
    {
        public void Run()
        {
        }

        [Fact]
        [Trait("Category", "Unit Test")]
        public void MyUnitTest()
        {
        }

        [Fact]
        [Trait("Category", "Integration Test")]
        public void MyIntegrationTest()
        {
        }
    }
}