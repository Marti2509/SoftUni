using System;
using System.Collections.Generic;

namespace P03.Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            List<Card> cards = new List<Card>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] cardInfo = input[i].Split(" ");
                string face = cardInfo[0];
                string suit = cardInfo[1];

                try
                {
                    Card newCard = new Card(face, suit);
                    cards.Add(newCard);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(string.Join(" ", cards));
        }
    }

    class Card
    {
        private List<string> faces = new List<string>
        {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A"
        };
        private Dictionary<string, string> suits = new Dictionary<string, string>
        {
            { "S", "\u2660" },
            { "H", "\u2665" },
            { "D", "\u2666" },
            { "C", "\u2663" }
        };
        private string face;
        private string suit;

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face
        {
            get { return face; }
            private set 
            {
                if (!faces.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }
                face = value; 
            }
        }

        public string Suit
        {
            get { return suit; }
            private set 
            {
                if (!suits.ContainsKey(value))
                {
                    throw new ArgumentException("Invalid card!");
                }
                suit = value; 
            }
        }

        public override string ToString()
        {
            return $"[{Face}{suits[Suit]}]";
        }
    }
}
