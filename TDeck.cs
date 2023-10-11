using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class TDeck
    {

        public List<Card> cards = new List<Card>();

        public TDeck() 
            { 
               InitializeDeck();
            }

        public void InitializeDeck()
        {


            for(int i = 0; i < 78; i++)
            {
                string name = TarValues.tars[i].Name;
                Card acard = new Card(name);
                acard.DisplayName = TarValues.tars[i].DisplayName; 
                cards.Add(acard);
            }

        }

        public Card GetCard(int index)
        {
            Card result = cards[index];

            return result;
        }


    }
}
