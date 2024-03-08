using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Utils;

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

        public Image CardImage;

        public int Index = -1;

        public Card(string name)
        {
            Name = name;
        }

        internal void GetCardData(string whichCard)
        {
            //UtilsNS.TarotCard tc = new UtilsNS.TarotCard();
            string tmp = RemoveWhiteSpace(whichCard);
            int index = UtilsNS.Utils.getTarotIndexByName(tmp);
            // Get the proper Name of the card.
            DisplayName = UtilsNS.Utils.GetImageTitleByIndex(index);
            Name = whichCard;
            string fullDescription = UtilsNS.Utils.getTarotMeaningByIndex(index);
            Debug.WriteLine(fullDescription);
            int pos = fullDescription.IndexOf(" Reversed");
            if(pos >= 0)
            { 
                Description = fullDescription.Substring(0, pos);
                ReversedDescription = fullDescription.Substring(pos + 1);
            }
            Suit = GetSuit(whichCard);
            Number = index.ToString();
            Index = index;
            IsReversed = false;
            DivinatoryMeaning = UtilsNS.Utils.tarotCardMeaningsFullText[index];
            // get the Image
            SetCardImage();
            
        }

        internal void SetCardImage()
        {
            if(Index == 0)
            {
                // The Fool
                this.CardImage = Sample.Properties.Resources.Capture00;
            }
            else if(Index == 1)
            {
                // The Magician
                this.CardImage = Sample.Properties.Resources.Capture02;
            }
            else if(Index == 2)
            {
                // The High Priestess
                CardImage = Sample.Properties.Resources.Capture03;
            }
            else if(Index == 3)
            {
                // The Empress
                CardImage = Sample.Properties.Resources.Capture04;
            }
            else if(Index == 4)
            {
                // The Emperor
                CardImage = Sample.Properties.Resources.Capture05;
            }
            else if(Index == 5)
            {
                // The Hierophant
                CardImage = Sample.Properties.Resources.Capture06;
            }
            else if(Index == 6)
            {
                // The Lovers
                CardImage = Sample.Properties.Resources.Capture07;
            }
            else if(Index ==7)
            {
                // The Chariot
                CardImage = Sample.Properties.Resources.Capture08;
            }
            else if(Index == 8)
            {
                // Strength
                CardImage = Sample.Properties.Resources.Capture09;
            }
            else if(Index == 9)
            {
                // The Hermit
                CardImage = Sample.Properties.Resources.Capture10;
            }
            else if(Index == 10)
            {
                // The Wheel of Fortune
                CardImage = Sample.Properties.Resources.Capture11;
            }
            else if(Index == 11)
            {
                // Justice
                CardImage = Sample.Properties.Resources.Capture12;
            }
            else if(Index == 12)
            {
                // The Hanged Man
                CardImage = Sample.Properties.Resources.Capture13;
            }
            else if(Index == 13)
            {
                // Death
                CardImage = Sample.Properties.Resources.Capture14;
            }
            else if(Index == 14)
            {
                // Temperance
                CardImage = Sample.Properties.Resources.Capture15;
            }
            else if(Index == 15)
            {
                // The Devil
                CardImage = Sample.Properties.Resources.Capture16;
            }
            else if(Index == 16)
            {
                // The Tower
                CardImage = Sample.Properties.Resources.Capture17;
            }
            else if(Index == 17)
            {
                // The Star
                CardImage = Sample.Properties.Resources.Capture18;
            }
            else if(Index == 18)
            {
                // The Moon
                CardImage = Sample.Properties.Resources.Capture19;
            }
            else if(Index == 19)
            {
                // The Sun
                CardImage = Sample.Properties.Resources.Capture20;
            }
            else if(Index == 20)
            {
                // Judgment
                CardImage = Sample.Properties.Resources.Capture21;
            }
            else if(Index == 21)
            {
                // The World
                CardImage = Sample.Properties.Resources.Capture22;
            }
            else if(Index == 22)
            {
                // Ace of Pentacles
                CardImage = Sample.Properties.Resources.Capture23;
            }
            else if(Index == 23)
            {
                // Two of Pentacles
                CardImage = Sample.Properties.Resources.Capture24;
            }
            else if(Index == 24)
            {
                // Three of Pentacles
                CardImage = Sample.Properties.Resources.Capture25;
            }
            else if(Index == 25)
            {
                // Four of Pentacles
                CardImage = Sample.Properties.Resources.Capture26;
            }
            else if(Index == 26)
            { 
                // Five of Pentacles
                CardImage = Sample.Properties.Resources.Capture27;
            }
            else if(Index == 27)
            {
                // Six of Pentacles
                CardImage = Sample.Properties.Resources.Capture28;
            }
            else if(Index == 28)
            {
                // Seven of Pentacles
                CardImage = Sample.Properties.Resources.Capture29;
            }
            else if(Index == 29)
            {
                // Eight of Pentacles
                CardImage = Sample.Properties.Resources.Capture30;
            }
            else if(Index == 30)
            {
                // Nine of Pentacles
                CardImage = Sample.Properties.Resources.Capture31;
            }
            else if(Index == 31)
            {
                // Ten of Pentacles
                CardImage = Sample.Properties.Resources.Capture32;
            }
            else if(Index == 32)
            {
                // Page of Pentacles
                CardImage = Sample.Properties.Resources.Capture33;
            }
            else if(Index == 33)
            {
                // Knight of Pentacles
                CardImage = Sample.Properties.Resources.Capture34;
            }
            else if(Index == 34)
            {
                // Queen of Pentacles
                CardImage = Sample.Properties.Resources.Capture35;
            }
            else if(Index == 35)
            {
                // King of Pentacles
                CardImage = Sample.Properties.Resources.Capture36;
            }
            else if(Index == 36)
            {
                // Ace of Wands
                CardImage = Sample.Properties.Resources.Capture37;
            }
            else if(Index == 37)
            {
                // Two of Wands
                CardImage = Sample.Properties.Resources.Capture38;
            }
            else if(Index == 38)
            {
                // Three of Wands
                CardImage = Sample.Properties.Resources.Capture39;
            }
            else if(Index == 39)
            {
                // Four of Wands
                CardImage = Sample.Properties.Resources.Capture40;
            }
            else if(Index == 40)
            {
                // Five of Wands
                CardImage = Sample.Properties.Resources.Capture41;
            }
            else if(Index == 41)
            {
                // Six of Wands
                CardImage = Sample.Properties.Resources.Capture42;
            }
            else if(Index == 42)
            {
                // Seven of Wands
                CardImage = Sample.Properties.Resources.Capture43;
            }
            else if(Index == 43)
            {
                // Eight of Wands
                CardImage = Sample.Properties.Resources.Capture44;
            }
            else if(Index == 44)
            {
                // Nine of Wands
                CardImage = Sample.Properties.Resources.Capture45;
            }
            else if(Index == 45)
            {
                // Ten of Wands
                CardImage = Sample.Properties.Resources.Capture46;
            }
            else if(Index == 46)
            {
                // Page of Wands
                CardImage = Sample.Properties.Resources.Capture47;
            }
            else if(Index == 47)
            {
                // Knight of Wands
                CardImage = Sample.Properties.Resources.Capture48;
            }
            else if(Index == 48)
            {
                // Queen of Wands
                CardImage = Sample.Properties.Resources.Capture49;
            }
            else if(Index == 49)
            {
                // King of Wands
                CardImage = Sample.Properties.Resources.Capture50;
            }
            else if(Index == 50)
            {
                // Ace of Cups
                CardImage = Sample.Properties.Resources.Capture51;
            }
            else if(Index == 51)
            {
                // Two of Cups
                CardImage = Sample.Properties.Resources.Capture52;
            }
            else if(Index == 52)
            {
                // Three of Cups
                CardImage = Sample.Properties.Resources.Capture53;
            }
            else if(Index == 53)
            {
                // Four of Cups
                CardImage = Sample.Properties.Resources.Capture54;
            }
            else if(Index == 54)
            {
                // Five of Cups
                CardImage = Sample.Properties.Resources.Capture55;
            }
            else if(Index == 55)
            {
                // Six of Cups
                CardImage = Sample.Properties.Resources.Capture56;
            }
            else if(Index == 56)
            {
                // Seven of Cups
                CardImage = Sample.Properties.Resources.Capture57;
            }
            else if(Index == 57)
            {
                // Eight of Cups
                CardImage = Sample.Properties.Resources.Capture58;
            }
            else if(Index == 58)
            {
                // Nine of Cups
                CardImage = Sample.Properties.Resources.Capture59;
            }
            else if(Index == 59)
            {
                // Ten of Cups
                CardImage = Sample.Properties.Resources.Capture60;
            }
            else if(Index == 60)
            {
                //  Page of Cups
                CardImage = Sample.Properties.Resources.Capture61;
            }
            else if(Index == 61)
            {
                // Knight of Cups
                CardImage = Sample.Properties.Resources.Capture62;
            }
            else if(Index == 62)
            {
                // Queen of Cups
                CardImage = Sample.Properties.Resources.Capture63;
            }
            else if(Index == 63)
            {
                // King of Cups
                CardImage = Sample.Properties.Resources.Capture64;
            }
            else if(Index == 64)
            {
                // Ace of Swords
                CardImage = Sample.Properties.Resources.Capture65;
            }
            else if(Index == 65)
            {
                // Two of Swords
                CardImage = Sample.Properties.Resources.Capture66;
            }
            else if(Index == 66)
            {
                // Three of Swords
                CardImage = Sample.Properties.Resources.Capture67;
            }
            else if(Index == 67)
            {
                // Four of Swords
                CardImage = Sample.Properties.Resources.Capture68;
            }
            else if(Index == 68)
            {
                // Five of Swords
                CardImage = Sample.Properties.Resources.Capture69;
            }
            else if(Index == 69)
            {
                // Six of Swords
                CardImage = Sample.Properties.Resources.Capture70;
            }
            else if(Index == 70)
            {
                // Seven of Swords
                CardImage = Sample.Properties.Resources.Capture71;
            }
            else if(Index == 71)
            {
                // Eight of Swords
                CardImage = Sample.Properties.Resources.Capture72;
            }
            else if(Index == 72)
            {
                // Nine of Swords
                CardImage = Sample.Properties.Resources.Capture73;
            }
            else if(Index == 73)
            {
                // Ten of Swords
                CardImage = Sample.Properties.Resources.Capture74;
            }
            else if(Index == 74)
            {
                // Page of Swords
                CardImage = Sample.Properties.Resources.Capture75;
            }
            else if(Index == 75)
            {
                // Knight of Swords
                CardImage = Sample.Properties.Resources.Capture76;
            }
            else if(Index == 76)
            {
                // Queen of Swords
                CardImage = Sample.Properties.Resources.Capture77;
            }
            else if(Index == 77)
            {
                // King of Swords
                CardImage = Sample.Properties.Resources.Capture78;
            }


        }

        internal string GetSuit(string src)
        {
            string result = string.Empty;
            if(src.Contains("Wands"))
            {
                result = "Wands";
            }
            else if(src.Contains("Pentacles"))
            {
                result = "Pentacles";
            }
            else if(src.Contains("Cups"))
            {
                result = "Cups";
            }
            else if(src.Contains("Swords"))
            {
                result = "Swords";
            }
            else
            {
                result = "Major";
            }

            return result;
        }

        internal string RemoveWhiteSpace(string inp)
        {
            string result = string.Empty;
            foreach(char c in inp)
            {
                if(c != ' ')
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
