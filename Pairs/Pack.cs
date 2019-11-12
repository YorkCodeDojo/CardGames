using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PackOfCards
{
    public class Pack
    {
        private readonly Card[] cards;

        public Card GetCard(int index) => cards[index];

        public Pack()
        {
            IEnumerable<Card> CreateSuit(Suit suit) =>
                    Enumerable.Range(1, 13).Select(cardNumber => new Card(suit, cardNumber));

            cards = CreateSuit(Suit.Heart)
             .Union(CreateSuit(Suit.Diamond))
             .Union(CreateSuit(Suit.Spade))
             .Union(CreateSuit(Suit.Club))
             .ToArray();
        }


        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var card in cards)
            {
                var face = card.ToString();
                sb.AppendLine(face);
            }

            return sb.ToString();
        }

        public int HowSuffled() => 52 - cards.Select((card, index) => (((int)card.Suit) * 13) + card.Value - 1 == index ? 1 : 0).Sum();

        internal void Shuffle(Random rnd)
        {
            var cardIndex1 = rnd.Next(0, 52);
            var cardIndex2 = rnd.Next(0, 52);

            SwapCards(cardIndex1, cardIndex2);
        }

        private void SwapCards(int cardIndex1, int cardIndex2)
        {
            var tempCard = cards[cardIndex1];
            cards[cardIndex1] = cards[cardIndex2];
            cards[cardIndex2] = tempCard;
        }
    }
}
