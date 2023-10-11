using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Card
    {
        public string Name;

        public string DisplayName;

        public string Description;

        public string ReversedDescription;

        public string Notes;

        public string Suit;

        public string Number;

        public bool   IsReversed = false;

        public string DivinatoryMeaning;

        public string WritersMeaning;

        public Card(string name)
        {
            Name = name;
        }

    }
}
