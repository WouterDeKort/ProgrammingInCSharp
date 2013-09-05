using System.ComponentModel;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-25 Using an implicit and explicit cast operator on a custom type.")]
    internal class UsingAnImplicitAndExplicitCastOperatorOnACustomType : ISample
    {
        public void Run()
        {
            var m = new Money(42.42M);
            decimal amount = m;
            var truncatedAmount = (int) m;
        }

        private class Money
        {
            public Money(decimal amount)
            {
                Amount = amount;
            }

            public decimal Amount { get; set; }

            public static implicit operator decimal(Money money)
            {
                return money.Amount;
            }

            public static explicit operator int(Money money)
            {
                return (int) money.Amount;
            }
        }
    }
}