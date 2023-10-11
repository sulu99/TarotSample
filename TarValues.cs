using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public sealed class TarValues
    {
        #region theValues
        public static readonly TarValues TheFool = new TarValues("TheFool", "The Fool");
        public static readonly TarValues TheMagician = new TarValues("TheMagician", "The Magician");
        public static readonly TarValues TheHighPriestess = new TarValues("TheHighPriestess", "The High Priestess");
        public static readonly TarValues TheEmpress = new TarValues("TheEmpress", "The Empress");
        public static readonly TarValues TheEmperor = new TarValues("TheEmperor", "The Emperor");
        public static readonly TarValues TheHierophant = new TarValues("TheHierophant", "The Hierophant");
        public static readonly TarValues TheLovers = new TarValues("TheLovers", "The Lovers");
        public static readonly TarValues TheChariot = new TarValues("TheChariot", "The Chariot");
        public static readonly TarValues Strength = new TarValues("Strength", "Strength");
        public static readonly TarValues TheHermit = new TarValues("TheHermit", "The Hermit");
        public static readonly TarValues WheelOfFortune = new TarValues("WheelOfFortune", "Wheel of Fortune");
        public static readonly TarValues Justice = new TarValues("Justice", "Justice");
        public static readonly TarValues TheHangedMan = new TarValues("TheHangedMan", "The Hanged Man");
        public static readonly TarValues Death = new TarValues("Death", "Death");
        public static readonly TarValues Temperance = new TarValues("Temperance", "Temperance");
        public static readonly TarValues TheDevil = new TarValues("TheDevil", "The Devil");
        public static readonly TarValues TheTower = new TarValues("TheTower", "The Tower");
        public static readonly TarValues TheStar = new TarValues("TheStar", "The Star"); 
        public static readonly TarValues TheMoon = new TarValues("TheMoon", "The Moon");
        public static readonly TarValues TheSun = new TarValues("TheSun", "The Sun");
        public static readonly TarValues Judgment = new TarValues("Judgment", "Judgment");
        public static readonly TarValues TheWorld = new TarValues("TheWorld", "The World");
        public static readonly TarValues AcePentacles = new TarValues("AcePentacles", "Ace of Pentacles");
        public static readonly TarValues TwoPentacles = new TarValues("TwoPentacles", "Two of Pentacles");
        public static readonly TarValues ThreePentacles = new TarValues("ThreePentacles", "Three of Pentacles");
        public static readonly TarValues FourPentacles = new TarValues("FourPentacles", "Four of Pentacles");
        public static readonly TarValues FivePentacles = new TarValues("FivePentacles", "Five of Pentacles");
        public static readonly TarValues SixPentacles = new TarValues("SixPentacles", "Six of Pentacles");
        public static readonly TarValues SevenPentacles = new TarValues("SevenPentacles", "Seven of Pentacles");
        public static readonly TarValues EightPentacles = new TarValues("EightPentacles", "Eight of Pentacles");
        public static readonly TarValues NinePentacles = new TarValues("NinePentacles", "Nine of Pentacles");
        public static readonly TarValues TenPentacles = new TarValues("TenPentacles", "Ten of Pentacles");
        public static readonly TarValues PagePentacles = new TarValues("PagePentacles", "Page of Pentacles");
        public static readonly TarValues KnightPentacles = new TarValues("KnightPentacles", "Knight of Pentacles");
        public static readonly TarValues QueenPentacles = new TarValues("QueenPentacles", "Queen of Pentacles");
        public static readonly TarValues KingPentacles = new TarValues("KingPentacles", "King of Pentacles");
        public static readonly TarValues AceWands = new TarValues("AceWands", "Ace of Wands");
        public static readonly TarValues TwoWands = new TarValues("TwoWands", "Two of Wands");
        public static readonly TarValues ThreeWands = new TarValues("ThreeWands", "Three of Wands");
        public static readonly TarValues FourWands = new TarValues("FourWands", "Four of Wands");
        public static readonly TarValues FiveWands = new TarValues("FiveWands", "Five of Wands");
        public static readonly TarValues SixWands = new TarValues("SixWands", "Six of Wands");
        public static readonly TarValues SevenWands = new TarValues("SevenWands", "Seven of Wands");
        public static readonly TarValues EightWands = new TarValues("EightWands", "Eight of Wands");
        public static readonly TarValues NineWands = new TarValues("NineWands", "Nine of Wands");
        public static readonly TarValues TenWands = new TarValues("TenWands", "Ten of Wands");
        public static readonly TarValues PageWands = new TarValues("PageWands", "Page of Wands");
        public static readonly TarValues KnightWands = new TarValues("KnightWands", "Knight of Wands");
        public static readonly TarValues QueenWands = new TarValues("QueenWands", "Queen of Wands");
        public static readonly TarValues KingWands = new TarValues("KingWands", "King of Wands");
        public static readonly TarValues AceCups = new TarValues("AceCups", "Ace of Cups");
        public static readonly TarValues TwoCups = new TarValues("TwoCups", "Two of Cups");
        public static readonly TarValues ThreeCups = new TarValues("ThreeCups", "Three of Cups");
        public static readonly TarValues FourCups = new TarValues("FourCups", "Four of Cups");
        public static readonly TarValues FiveCups = new TarValues("FiveCups", "Five of Cups");
        public static readonly TarValues SixCups = new TarValues("SixCups", "Six of Cups");
        public static readonly TarValues SevenCups = new TarValues("SevenCups", "Seven of Cups");
        public static readonly TarValues EightCups = new TarValues("EightCups", "Eight of Cups");
        public static readonly TarValues NineCups = new TarValues("NineCups", "Nine of Cups");
        public static readonly TarValues TenCups = new TarValues("TenCups", "Ten of Cups");
        public static readonly TarValues PageCups = new TarValues("PageCups", "Page of Cups");
        public static readonly TarValues KnightCups = new TarValues("KnightCups", "Knight of Cups");
        public static readonly TarValues QueenCups = new TarValues("QueenCups", "Queen of Cups");
        public static readonly TarValues KingCups = new TarValues("KingCups", "King of Cups");
        public static readonly TarValues AceSwords = new TarValues("AceSwords", "Ace of Swords");
        public static readonly TarValues TwoSwords = new TarValues("TwoSwords", "Two of Swords");
        public static readonly TarValues ThreeSwords = new TarValues("ThreeSwords", "Three of Swords");
        public static readonly TarValues FourSwords = new TarValues("FourSwords", "Four of Swords");
        public static readonly TarValues FiveSwords = new TarValues("FiveSwords", "Five of Swords");
        public static readonly TarValues SixSwords = new TarValues("SixSwords", "Six of Swords");
        public static readonly TarValues SevenSwords = new TarValues("SevenSwords", "Seven of Swords");
        public static readonly TarValues EightSwords = new TarValues("EightSwords", "Eight of Swords");
        public static readonly TarValues NineSwords = new TarValues("NineSwords", "Nine of Swords");
        public static readonly TarValues TenSwords = new TarValues("TenSwords", "Ten of Swords");
        public static readonly TarValues PageSwords = new TarValues("PageSwords", "Page of Swords");
        public static readonly TarValues KnightSwords = new TarValues("KnightSwords", "Knight of Swords");
        public static readonly TarValues QueenSwords = new TarValues("QueenSwords", "Queen of Swords");
        public static readonly TarValues KingSwords = new TarValues("KingSwords", "King of Swords");
        #endregion theValues

        public static TarValues[] tars = new TarValues[78]
        {
            TheFool, TheMagician, TheHighPriestess, TheEmpress, TheEmperor, TheHierophant, TheLovers, TheChariot, Strength, TheHermit, WheelOfFortune,
            Justice, TheHangedMan, Death, Temperance, TheDevil, TheTower, TheStar, TheMoon, TheSun, Judgment, TheWorld, AcePentacles,
            TwoPentacles, ThreePentacles, FourPentacles, FivePentacles, SixPentacles, SevenPentacles, EightPentacles, NinePentacles, TenPentacles,
            PagePentacles, KnightPentacles, QueenPentacles, KingPentacles, AceWands, TwoWands, ThreeWands, FourWands, FiveWands, SixWands, 
            SevenWands, EightWands, NineWands, TenWands, PageWands, KnightWands, QueenWands, KingWands, AceCups, TwoCups, ThreeCups, FourCups,
            FiveCups, SixCups, SevenCups, EightCups, NineCups, TenCups, PageCups, KnightCups, QueenCups, KingCups, AceSwords, TwoSwords,
            ThreeSwords, FourSwords, FiveSwords, SixSwords, SevenSwords, EightSwords, NineSwords, TenSwords, PageSwords, KnightSwords, QueenSwords, KingSwords
        };


        public readonly string Name;
        public readonly string DisplayName;
        public int Length = 78;

        // Indexer Declaration
        [System.Runtime.CompilerServices.IndexerName("Item")]
        public TarValues this[int index]
        {
            // get and set accessors.
            get
            {
                return tars[index];
            }
            private set
            {

            }

        }


        private TarValues(string name, string displayName)
        {
            Name = name;
            DisplayName = displayName;
        }

    }
}
