using System.Globalization;

namespace PackOfCards
{
    public readonly struct Card
    {
        public Card(Suit suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public Suit Suit { get; }
        public int Value { get; }

        public string Filename()
        {
            switch (Value)
            {
                case 1:
                    return $"cards/Ace_of_{Suit}s.png";
                case 11:
                    return $"cards/Jack_of_{Suit}s.png";
                case 12:
                    return $"cards/Queen_of_{Suit}s.png";
                case 13:
                    return $"cards/King_of_{Suit}s.png";
                default:
                    return $"cards/{Value}_of_{Suit}s.png";
            }
        }
    }
}
