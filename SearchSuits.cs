using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class SearchSuits : Form
    {
        int GroupId = -1;
        public SearchSuits()
        {
            InitializeComponent();
            PopulateComboBox(GroupId);
        }


        private void majorArcanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupId = 0;  // Major Arcana selected
            PopulateComboBox(GroupId);

        }

        /// <summary>
        /// Puts values into combobox based on what the user has selected.
        /// </summary>
        /// <param name="groupId"></param>
        private void PopulateComboBox(int groupId)
        {
            combo1.Items.Clear();
            switch(groupId)
            {
                case 0: // Major Arcana
                {
                    combo1.Items.Add("The Fool");
                    combo1.Items.Add("The Magician");
                    combo1.Items.Add("The High Priestess");
                    combo1.Items.Add("The Empress");
                    combo1.Items.Add("The Emperor");
                    combo1.Items.Add("The Hierophant");
                    combo1.Items.Add("The Lovers");
                    combo1.Items.Add("The Chariot");
                    combo1.Items.Add("Strength");
                    combo1.Items.Add("The Hermit");
                    combo1.Items.Add("Wheel of Fortune");
                    combo1.Items.Add("Justice");
                    combo1.Items.Add("The Hanged Man");
                    combo1.Items.Add("Death");
                    combo1.Items.Add("Temperance");
                    combo1.Items.Add("The Devil");
                    combo1.Items.Add("The Tower");
                    combo1.Items.Add("The Star");
                    combo1.Items.Add("The Moon");
                    combo1.Items.Add("The Sun");
                    combo1.Items.Add("Judgment");
                    combo1.Items.Add("The World");
                    return;
                }break;
                case 1: // Cups
                {
                    combo1.Items.Add("Ace of Cups");
                    combo1.Items.Add("Two of Cups");
                    combo1.Items.Add("Three of Cups");
                    combo1.Items.Add("Four of Cups");
                    combo1.Items.Add("Five of Cups");
                    combo1.Items.Add("Six of Cups");
                    combo1.Items.Add("Seven of Cups");
                    combo1.Items.Add("Eight of Cups");
                    combo1.Items.Add("Nine of Cups");
                    combo1.Items.Add("Ten of Cups");
                    combo1.Items.Add("Page of Cups");
                    combo1.Items.Add("Knight of Cups");
                    combo1.Items.Add("Queen of Cups");
                    combo1.Items.Add("King of Cups");
                    return;
                } break;
                case 2:
                {
                    combo1.Items.Add("Ace of Swords");
                    combo1.Items.Add("Two of Swords");
                    combo1.Items.Add("Three of Swords");
                    combo1.Items.Add("Four of Swords");
                    combo1.Items.Add("Five of Swords");
                    combo1.Items.Add("Six of Swords");
                    combo1.Items.Add("Seven of Swords");
                    combo1.Items.Add("Eight of Swords");
                    combo1.Items.Add("Nine of Swords");
                    combo1.Items.Add("Ten of Swords");
                    combo1.Items.Add("Page of Swords");
                    combo1.Items.Add("Knight of Swords");
                    combo1.Items.Add("Queen of Swords");
                    combo1.Items.Add("King of Swords");
                    return;
                } break;
                case 3:
                {
                    combo1.Items.Add("Ace of Pentacles");
                    combo1.Items.Add("Two of Pentacles");
                    combo1.Items.Add("Three of Pentacles");
                    combo1.Items.Add("Four of Pentacles");
                    combo1.Items.Add("Five of Pentacles");
                    combo1.Items.Add("Six of Pentacles");
                    combo1.Items.Add("Seven of Pentacles");
                    combo1.Items.Add("Eight of Pentacles");
                    combo1.Items.Add("Nine of Pentacles");
                    combo1.Items.Add("Ten of Pentacles");
                    combo1.Items.Add("Page of Pentacles");
                    combo1.Items.Add("Knight of Pentacles");
                    combo1.Items.Add("Queen of Pentacles");
                    combo1.Items.Add("King of Pentacles");
                    return;
                } break;
                case 4:
                {
                    combo1.Items.Add("Ace of Wands");
                    combo1.Items.Add("Two of Wands");
                    combo1.Items.Add("Three of Wands");
                    combo1.Items.Add("Four of Wands");
                    combo1.Items.Add("Five of Wands");
                    combo1.Items.Add("Six of Wands");
                    combo1.Items.Add("Seven of Wands");
                    combo1.Items.Add("Eight of Wands");
                    combo1.Items.Add("Nine of Wands");
                    combo1.Items.Add("Ten of Wands");
                    combo1.Items.Add("Page of Wands");
                    combo1.Items.Add("Knight of Wands");
                    combo1.Items.Add("Queen of Wands");
                    combo1.Items.Add("King of Wands");
                    return;
                } break;
            }
        }

        private void cupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupId = 1; // Cups
            PopulateComboBox(GroupId);

        }

        private void swordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupId = 2; // Swords
            PopulateComboBox(GroupId);

        }

        private void pentaclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupId = 3; // Pentacles
            PopulateComboBox(GroupId);

        }

        private void wandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupId = 4; // Wands
            PopulateComboBox(GroupId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the index changes, the user has selected a card in the group.
            string whichCard = combo1.SelectedItem.ToString();
            string Id = GetCardIdGivenProperName(whichCard);
            ShowCardData(Id);
        }
        
        internal string GetCardIdGivenProperName(string src)
        {
            string result= string.Empty;
            if(src == "The Fool")
            {
                result = "TheFool";
            }
            else if(src == "The Magician")
            {
                result = "TheMagician";
            }
            else if (src == "The High Priestess")
            {
                result = "TheHighPriestess";            
            }
            else if (src == "The Empress")
            {
                result = "TheEmpress";
            }
            else if (src == "The Emperor")
            {
                result = "TheEmperor";
            }
            else if (src == "The Hierophant")
            {
                result = "TheHierophant";
            }
            else if (src == "The Lovers")
            {
                result = "TheLovers";
            }
            else if (src == "The Chariot")
            {
                result = "TheChariot";
            }
            else if (src == "Strength")
            {
                result = "Strength";
            }
            else if (src == "The Hermit")
            {
                result = "TheHermit";
            }
            else if (src == "Wheel of Fortune")
            {
                result = "TheWheelOfFortune";
            }
            else if (src == "Justice")
            {
                result = "Justice";
            }
            else if (src == "The Hanged Man")
            {
                result = "TheHangedMan";
            }
            else if (src == "Death")
            {
                result = "Death";
            }
            else if (src == "Temperance")
            {
                result = "Temperance";
            }
            else if (src == "The Devil")
            {
                result = "TheDevil";
            }
            else if (src == "The Tower")
            {
                result = "TheTower";
            }
            else if (src == "The Star")
            {
                result = "TheStar";
            }
            else if (src == "The Moon")
            {
                result = "TheMoon";
            }
            else if (src == "The Sun")
            {
                result = "TheSun";
            }
            else if (src == "Judgment")
            {
                result = "Judgment";
            }
            else if (src == "The World")
            {
                result = "TheWorld";
            }
            else if (src == "Ace of Cups")
            {
                result = "AceCups";
            }
            else if (src == "Two of Cups")
            {
                result = "TwoCups";
            }
            else if (src == "Three of Cups")
            {
                result = "ThreeCups";
            }
            else if (src == "Four of Cups")
            {
                result = "FourCups";
            }
            else if (src == "Five of Cups")
            {
                result = "FiveCups";
            }
            else if (src == "Six of Cups")
            {
                result = "SixCups";
            }
            else if (src == "Seven of Cups")
            {
                result = "SevenCups";
            }
            else if (src == "Eight of Cups")
            {
                result = "EightCups";
            }
            else if (src == "Nine of Cups")
            {
                result = "NineCups";
            }
            else if (src == "Ten of Cups")
            {
                result = "TenCups";
            }
            else if (src == "Page of Cups")
            {
                result = "PageCups";
            }
            else if (src == "Knight of Cups")
            {
                result = "KnightCups";
            }
            else if (src == "Queen of Cups")
            {
                result = "QueenCups";
            }
            else if (src == "King of Cups")
            {
                result = "KingCups";
            }
            else if (src == "Ace of Swords")
            {
                result = "AceSwords";
            }
            else if (src == "Two of Swords")
            {
                result = "TwoSwords";
            }
            else if (src == "Three of Swords")
            {
                result = "ThreeSwords";
            }
            else if (src == "Four of Swords")
            {
                result = "FourSwords";
            }
            else if (src == "Five of Swords")
            {
                result = "FiveSwords";
            }
            else if (src == "Six of Swords")
            {
                result = "SixSwords";
            }
            else if (src == "Seven of Swords")
            {
                result = "SevenSwords";
            }
            else if (src == "Eight of Swords")
            {
                result = "EightSwords";
            }
            else if (src == "Nine of Swords")
            {
                result = "NineSwords";
            }
            else if (src == "Ten of Swords")
            {
                result = "TenSwords";
            }
            else if (src == "Page of Swords")
            {
                result = "PageSwords";
            }
            else if (src == "Knight of Swords")
            {
                result = "KnightSwords";
            }
            else if (src == "Queen of Swords")
            {
                result = "QueenSwords";
            }
            else if (src == "King of Swords")
            {
                result = "KingSwords";
            }
            else if (src == "Ace of Pentacles")
            {
                result = "AcePentacles";
            }
            else if (src == "Two of Pentacles")
            {
                result = "TwoPentacles";
            }
            else if (src == "Three of Pentacles")
            {
                result = "ThreePentacles";
            }
            else if (src == "Four of Pentacles")
            {
                result = "FourPentacles";
            }
            else if (src == "Five of Pentacles")
            {
                result = "FivePentacles";
            }
            else if (src == "Six of Pentacles")
            {
                result = "SixPentacles";
            }
            else if (src == "Seven of Pentacles")
            {
                result = "SevenPentacles";
            }
            else if (src == "Eight of Pentacles")
            {
                result = "EightPentacles";
            }
            else if (src == "Nine of Pentacles")
            {
                result = "NinePentacles";
            }
            else if (src == "Ten of Pentacles")
            {
                result = "TenPentacles";
            }
            else if (src == "Page of Pentacles")
            {
                result = "PagePentacles";
            }
            else if (src == "Knight of Pentacles")
            {
                result = "KnightPentacles";
            }
            else if (src == "Queen of Pentacles")
            {
                result = "QueenPentacles";
            }
            else if (src == "King of Pentacles")
            {
                result = "KingPentacles";
            }
            else if(src == "Ace of Wands")
            {
                result = "AceWands";
            }
            else if (src == "Two of Wands")
            {
                result = "TwoWands";
            }
            else if (src == "Three of Wands")
            {
                result = "ThreeWands";
            }
            else if (src == "Four of Wands")
            {
                result = "FourWands";
            }
            else if (src == "Five of Wands")
            {
                result = "FiveWands";
            }
            else if (src == "Six of Wands")
            {
                result = "SixWands";
            }
            else if (src == "Seven of Wands")
            {
                result = "SevenWands";
            }
            else if (src == "Eight of Wands")
            {
                result = "EightWands";
            }
            else if (src == "Nine of Wands")
            {
                result = "NineWands";
            }
            else if (src == "Ten of Wands")
            {
                result = "TenWands";
            }
            else if (src == "Page of Wands")
            {
                result = "PageWands";
            }
            else if (src == "Knight of Wands")
            {
                result = "KnightWands";
            }
            else if (src == "Queen of Wands")
            {
                result = "QueenWands";
            }
            else if (src == "King of Wands")
            {
                result = "KingWands";
            }


            return result;
        }

        /// <summary>
        /// Given the card title, populate the form
        /// </summary>
        /// <param name="whichCard"></param>
        private void ShowCardData(string whichCard)
        {
             Card displayCard = new Card(whichCard);
            displayCard.GetCardData(whichCard);
            // populate the form with the card data
            lblTitle.Text = displayCard.DisplayName;
            lblGeneralDescription.Text = displayCard.Description;
            lblDescriptionReversed.Text = displayCard.ReversedDescription;
            picBox1.Image = displayCard.CardImage;
            string s = UtilsNS.Utils.getTarotFullMeaning(displayCard.DisplayName);
            txtDivineMeaning.Text = s;
        }
    }
}
