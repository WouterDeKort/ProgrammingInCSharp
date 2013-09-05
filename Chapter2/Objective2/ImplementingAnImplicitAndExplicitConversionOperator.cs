using System.ComponentModel;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-24 Implementing an implicit and explicit conversion operator.")]
    internal class ImplementingAnImplicitAndExplicitConversionOperator : ISample
    {
        public void Run()
        {
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