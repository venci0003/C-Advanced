using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Cards
{
    public class StartUp
    {
        static void Main(string[] args)
        {

        }
    }

    public class Card
    {
        Dictionary<string, string> cardSymbols = new Dictionary<string, string>()
        {
            {"S","\u2660"},
            {"H","\u2665"},
            {"D","\u2666"},
            {"C","\u2663"}

        };
        private string[] arrayFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        private string[] arraySuits = new string[] { "S", "H", "D", "C" };

        private string cardFace;
        private string cardSuit;

        public string CardFace
        {
            get
            {
                return cardFace;
            }
            private set
            {
                if (!arrayFaces.Contains(value))
                {
                    throw new ArgumentException("Invalid card");
                }

                cardFace = value;
            }
        }

        public string CardSuit
        {
            get
            {
                return cardSuit;
            }
            set
            {
                if (!arraySuits.Contains(value))
                {
                    throw new ArgumentException("Invalid card");
                }

                cardSuit = value;
            }
        }

        public override string ToString()
        {
            return $"{cardFace}{cardSymbols}";
        }
    }
}
