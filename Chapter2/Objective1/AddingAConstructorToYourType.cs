using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-11 Adding a constructor to your type.")]
    internal class AddingAConstructorToYourType : ISample
    {
        public void Run()
        {
        }

        private class Card
        {
        }

        private class Deck
        {
            private int _maximumNumberOfCards;

            public Deck(int maximumNumberOfCards)
            {
                _maximumNumberOfCards = maximumNumberOfCards;
                Cards = new List<Card>();
            }

            public List<Card> Cards { get; set; }
        }
    }
}