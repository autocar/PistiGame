using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistiGameDomain
{
    public class Deck
    {
        public List<Card> CardDeck;
        public Stack<Card> ShuffleCard;
        public string closedCardPath;
        public Deck()
        {
            CardDeck = new List<Card>();
            ShuffleCard = new Stack<Card>();
            GenerateCards();
        }

        private void GenerateCards()
        {
            for (int CardType = 0; CardType < 4; CardType++)
            {
                for (int CardNumber = 1; CardNumber <= 13; CardNumber++)
                {
                    Card newCard = new Card((CardTypes)CardType, CardNumber, @"F:\WindowsFormUygulamaları\PistiGameExample\PistiGameDomain\Resources\" + (CardType * 13 + CardNumber) + ".png");
                    CardDeck.Add(newCard);
                }
            }
            closedCardPath = @"F:\WindowsFormUygulamaları\PistiGameExample\PistiGameDomain\Resources\closedCard.png";
        }

        public void ShuffleCards(List<Card> deck)
        {
            Random rnd = new Random();
            int p = 0;
            while (deck.Count() > 0)
            {
                p = rnd.Next(0, deck.Count());
                ShuffleCard.Push(deck[p]);
                deck.RemoveAt(p);
            }
        }
    }
}
