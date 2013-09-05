using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-10 Creating a collection such as a Deck class.")]
    internal class CreatingACollectionSuchAsADeckClass : ISample
    {
        public void Run()
        {
            var myList = new List<int> {1, 3, 5};
            myList[0] = 1;

            var deck = new Deck();
            deck.Cards.Add(new Card());

            Card c1 = deck[0];
        }

        private class Card
        {
        }

        private class Deck
        {
            public Deck()
            {
                Cards = new List<Card>();
            }

            public ICollection<Card> Cards { get; private set; }

            public Card this[int index]
            {
                get { return Cards.ElementAt(index); }
            }
        }
    }
}