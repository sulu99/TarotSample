#region usings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Sample.Properties;
using System.Windows.Forms.VisualStyles;

#endregion usings

namespace Sample
{
    public partial class frmMain : Form
    {
        System.Security.Cryptography.RandomNumberGenerator CryptoRNG;
        int CurrentFormState = 0;  // 0 means form is shrunken size. 1 is the bigger size.

        /// <summary>
        /// The frmMain method sets up the UI components of the form and creates any object instances it needs.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            if (CryptoRNG == null)
            {
                CryptoRNG = RandomNumberGenerator.Create();
            }

            // Ensure that the Initial Form State is the smaller one.
            CurrentFormState = 0;
            ShrinkForm();
        }

        private void drawOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int min = 1;
            int max = 78;
            int index = RandomIntFromRNG(min, max);
            lblQuote.Text = "";
            lblQuote.Text += "Capture" + index.ToString("D2");
            string suffix = index.ToString("D2");
            string cardImageName = "Capture" + suffix;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImage = (System.Drawing.Image)Resources.ResourceManager.GetObject(cardImageName);
            pictureBox1.Refresh();
            lblName.Text = GetDisplayName(index);
            bool isReversed = DetermineReversal();
            lblSummary.Text = GetSummary(index, isReversed);
            lblQuote.Text = GetQuotation(index);

        }

        public bool DetermineReversal()
        {
            bool result = false;

            int idx = RandomIntFromRNG(0, 1000);

            if(idx <= 700)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        private string GetSummary(int index, bool isReversed)
        {
            string result = string.Empty;


            // The Fool
            if (index == 1 && isReversed == false)
            {
                result = "Summary: Folly, mania, extravagance, intoxication, the state of being lost, delirium, frenzy, bewrayment.";
            }
            else
            {
                result = "Summary: Negligence, absence, distribution, carelessness, apathy, nullity, vanity.";
            }

            // The Magician
            if (index == 2)
            {
                if (isReversed == false)
                {
                    result = "Summary: Skill, dipolmacy, address, subtlety; sickness pain, loss, disaster, snares of enemies; self-confidence, will. The Querent, if male, Skill, Will-Power, Dexterity.";
                }
                else
                {
                    result = "Summary: Reversed will also apply to evil ends, Weakness of Will, Cunning, Knavishness, and Madness. Usually Stands for Physician, Magus, mental disease, disgrace, and disquiet when reversed.";
                }
            }


            // The High Priestess
            if (index == 3)
            {
                if (isReversed == false)
                {
                    result = "Secrets, mystery, the future as yet unrevealed. The woman who interests the Querent, if male. If not male, the querent herself, the female: silence, tenacity, mystery, wisdom, and science.";
                }
                else
                {
                    result = "Passion, moral, or physical ardour, conceit, surface-knowledge";
                }
            }

            // The Empress
            if (index == 4)
            {
                if (isReversed == false)
                {
                    result = "Summary: Fruitfulness, action, initiative, length of days; the unknown, the clandestine. Also: difficulty, doubt, and ignorance.";
                }
                else
                {
                    result = "Summary: Light, the truth, the unravelling of involved matters, a public rejoicing; according to another interpretation - a vacillation.";
                }

            }

            // The Emperor
            if (index == 5)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Emperor upright indicates Stability, power, protection, realization. A Great Person. Also: aid, reason, conviction, authority, and Will.";
                }
                else
                {
                    result = "Summary: The Emperor Reversed indicates Benevolence, compassion, and credit; it also adds confusion to his enemies, Obstruction to the, and reveals their Immaturity.";
                }
            }

            // The Hierophant
            if (index == 6)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Hierophant upright indicates Marriage, alliance, captivity, servitude. By another interpretation, it can indicate mercy and goodness and inspiration; the man to whom the Querent has recourse.";
                }
                else
                {
                    result = "Summary: The Hierophant reversed indicates Society, good understanding, concord, over-kindness, and unsuspecting weakness.";
                }
            }

            // The Lovers
            if (index == 7)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Lovers is a card that represents Attraction, Love, Beauty, and Trials Overcome. ";
                }
                else
                {
                    result = "Summary: The Lovers when reversed represents: Failure, foolish designs. Another interpretation speaks of Marriage frustrated and contrarieties of all kinds.";
                }
            }

            // The Chariot
            if (index == 8)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Chariot in its upright position stands for Succour, Providence and War, triumph, presumption, vengeance, and Trouble. Because it is The Chariot, it can also represent Travel Soon";
                }
                else
                {
                    result = "Summary: The Chariot in its reversed position stands for Riot, quarrel, dispute, litigation, and defeat. Its reversal seems to magnify the worst qualities of the card.";
                }
            }

            // Strength or Fortitude
            if (index == 9)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Strength or Fortitude card when in its upright position usually stands for Power, Energy, Action, Courage, and Magnanimity. Also complete Success and Honour.";
                }
                else
                {
                    result = "Summary: The Strength or Fortitude card in its Reversed position stands for Despotism, Abuse of Power, Weakness, Discord, and sometimes even Disgrace.";
                }
            }


            // The Hermit
            if (index == 10)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Hermit card in an upright position normally stands for Prudence, Circumspection and also especially Treason, Dissimulation, Roguery and Corruption.";
                }
                else
                {
                    result = "Summary: The Hermit in its Reversed position stands for Concealment, Disguise, Policy, Fear, and Unreasoned Caution. This one seems to magnify the worst aspects of its Upright position.";
                }
            }

            // Wheel of Fortune
            if (index == 11)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Wheel of Fortune in an upright position usually stands for Destiny, Fortune, Success, Elevation, Luck, and Felicity.";
                }
                else
                {
                    result = "Summary: The Wheel of Fortune in a reversed position usually stands for Increase, Abundance, and Superfluity. This seems to magnify the upright meaning.";
                }
            }

            // Justice
            if (index == 12)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Justice card in the upright position usually stands for: Equity, Rightness, Probity, Executive and a triumph of the deserving side in the law.";
                }
                else
                {
                    result = "Summary: The Justic card in the Reversed position usually means Law in all its Departments, Legal Complications, bigotry, bias, and excessive severity.";
                }
            }

            // The Hanged Man
            if (index == 13)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Hanged Man in the Upright position usually stands for Wisdom, Circumspection, Discernment, Trials, Sacrifice, Intuition, Divination, Prophecy.";
                }
                else
                {
                    result = "Summary: The Hanged Man in the Reversed position usually stands for Selfishness, The Crowd, the Body Politic";
                }
            }

            // Death
            if (index == 14)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Death card in an upright position usually stands for End, Mortality, Destruction, Corruption, and also, for a man, the loss of a Benefactor and for a woman many contrarieties, and for a maid, the failure of marriage projects.";
                }
                else
                {
                    result = "Summary: The Death card in a reversed position usually means Inertia, Sleep Lethargy, Petrifaction, Somnambulism, and Hope Destroyed.";
                }
            }

            // Temperance
            if (index == 15)
            {
                if (isReversed == false)
                {
                    result = "Summary: Temperance in the upright position usually means Economy, Moderation, Frugality, Management, and Accommodation.";
                }
                else
                {
                    result = "Summary: Temperance in the reversed position usually means Things connected with Churches, Religions, Sects, the Priesthood, sometimes even the priest who will marry the Querent; also Disunion, Unfortunate Combinations, and Competing Interests.";
                }
            }

            // The Devil
            if (index == 16)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Devil in the upright position usually indicates Ravage, Violence, Vehemence, Extraordinary Efforts, Force, Fatality, That Which is Predestined but is not for this reason Evil.";
                }
                else
                {
                    result = "Summary: The Devil in the reversed position usually means Evil Fatality, Weakness, Pettiness, and Blindess.";
                }
            }

            // The Tower
            if (index == 17)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Tower in the upright position usually means Misery, Distress, Indigence, Adversity, Calamity, Disgrace, Deception, and Ruin. It is a card in particular of Unforeseen Catastrophe.";
                }
                else
                {
                    result = "Summary: The Tower in the reversed position means According to one account, the same as upright in a lesser degree, but also Oppression, Imprisonment, Tyranny. (Upright was: Misery, Distress, Indigence, Adversity, Calamity, Disgrace, Deception, and Ruin. A card of Unforeseen Catastrophe.)";
                }
            }

            // The Star
            if (index == 18)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Star in the upright position represents Loss, Theft, Privation, Abandonment; another interpretation says Hope and Bright Prospects. ";
                }
                else
                {
                    result = "Summary: The Star in the reversed position traditionally means Arrogance, Haughtiness, and Impotence.";
                }
            }

            // The Moon
            if (index == 19)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Moon in the upright position traditionally means: Hidden enemies, Danger, Calumny, Darkness, Terror, Deception, Occult Forces, and Error";
                }
                else
                {
                    result = "Summary: The Moon in the reversed position means: Instability, Inconstancy, Silence, and lesser degrees of Deception and Error. Can be used as a magnifier.";
                }
            }

            // The Sun
            if (index == 20)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Sun in the upright position means Material Happiness, Fortunate Marriage, and Contentment";
                }
                else
                {
                    result = "Summary: The Sun in the reversed position means Material Happiness, Fortunate Marriage, Contentment, but all in a lesser degree.";
                }
            }

            // The Last Judgment
            if (index == 21)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Last Judgment card in the upright position stands for Change of Position, Renewal, Outcome. Another account specifies Total Loss through Lawsuit.";
                }
                else
                {
                    result = "Summary: The Last Judgment card in the reversed position means Weakness, Pusillanimity, Simplicity, and also Deliberation, Decision, and Sentence (in the legal sense).";
                }
            }

            // The World
            if (index == 22)
            {
                if (isReversed == false)
                {
                    result = "Summary: The World card in the upright position stands for Assured Success, Recompense, Voyage, Route, Emigration, Flight, Change of Place.";
                }
                else
                {
                    result = "Summary: The World card in the reversed position stands for Inertia, Fixity, Stagnation, and Dreadful Permanence";
                }
            }



            // Ace of Pentacles (or Clubs)
            if (index == 23)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Ace of Pentacles in the upright position usually means Perfect Contentment, Felicity, Happiness, Ecstasy, Perfect Joy, Perfect Remedy, and fulfilment of what has been asked in prayer.";
                }
                else
                {
                    result = "Summary: The Ace of Pentacles in the reversed position usually indicates: Capital, Riches, Opulence, Treasure. Someting of Principal Value or Valuable, Dear, Expensive, Rare, and Highly Esteemed. This position seems to be a magnifier.";
                }
            }

            // Two of Pentacles
            if (index == 24)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Two of Pentacles in an upright position indicates Embarrassment, Obstacles, Obstruction, Emotion, Confusion, Difficulty, Hindrance, or Unrest.";
                }
                else
                {
                    result = "Summary: The Two of Pentacles in a reversed position indicates it is given as a Message, Writing, Doctrine, Literature, Work, Book Production, Composition, Epistle, Elements, Principles; Checques. Another interpretation gives 'A card of gaiety, recreation, and its connections.'";
                }
            }


            // Three of Pentacles
            if (index == 25)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Three of Pentacles in an upright position indicates Nobility, Noblesse, Good and generous action, Aristocracy, Fame, Glory, Splendour, etc.";
                }
                else
                {
                    result = "Summary: The Three of Pentacles in the reversed position meanings do not appear at all to respond to a card of a pentacle nature, and as in other cases, simply seem to imply the ABSENCE of the better qualities, hence: Weakness, Humility, Vile and Abject action, etc. ";
                }
            }


            // Four of Pentacles
            if (index == 26)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Four of Pentacles in an upright position indicates A Present, Gratification, Gift, Inheritance, Legacy; Liberality, Generosity, Offerings, etc. The Surety of these possessions, Cleaving to that which one has.";
                }
                else
                {
                    result = "Summary: The Four of Pentacles in a Reversed position is said to represent a circle, a circuit, and in general that which limits, encircles, holds, walls in, and encloses. So it may refer to a Convent, a Jail, a Monastery. Further obstacles, Delay, and Suspense.";
                }
            }


            // Five of Pentacles
            if (index == 27)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Five of Pentacles in the upright position usually indicates Lover, Mistress, also Husband & Wife, Friend, or Beloved Person. Also accord, convenience, well-being and affinity.";
                }
                else
                {
                    result = "Summary: The Five of Pentacles in the reversed position usually indicates Bad Conduct, Ruin even, Confusion, Disorder, Discord, Dissipation, Chaos, Profligacy. It fortells material troubles above all.";
                }
            }


            // Six of Pentacles
            if (index == 28)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Six of Pentacles in the upright position represents The Present, the actual moment, To-Day; a witness, contemporary, attention, good care, vigilance. Also: presents, gifts, gratifications, and prosperity.";
                }
                else
                {
                    result = "Summary: The Six of Pentacles reversed is said to denote Cupidity, Jealousy, Desire, and Passion, lust and researches.";
                }
            }


            // Seven of Pentacles
            if (index == 29)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Seven of Pentacles in the upright position indicates Money, Riches, Sums of Money, also Silver especially. It has to do with the Moon and Whiteness. Also: Candour, innocence, purgation, purification, business, and barter.";
                }
                else
                {
                    result = "Summary: The Seven of Pentacles in the reversed position indicates Mental Worry, Suspicions, Diligence, Fear, Mistrust, Paranoia, etc.";
                }
            }

            // Eight of Pentacles
            if (index == 30)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Eight of Pentacles in the upright position represents Honest Work and Industry. Work Employment, craftsmanship, and skill in craft and business leading to Abundance, Hospitality, Politeness, Kind Reception, Majority, and Augmentation.";
                }
                else
                {
                    result = "Summary: The Eight of Pentacles in the Reversed position covers Usury, Voided Ambitions, Vanity, Cupidity, Avarice.";
                }
            }

            // Nine of Pentacles
            if (index == 31)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Nine of Pentacles in an upright position covers Effect, Realisation, Accomplishment; positive certain fulfilment of what is presaged by the neighboring cards, succeeding.";
                }
                else
                {
                    result = "Summary: The Nine of Pentacles in a Reversed position is said to give Deception, Bad Faith, Vain Hope, Idle Promise, etc.";
                }
            }


            // Ten of Pentacles
            if (index == 32)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Ten of Pentacles in an upright position is said to indicate the house and household, economy, gain, riches, family matters, archives, building a castle as well as a hut, a vessel, a ship, a race, posterity, fortune, and game.";
                }
                else
                {
                    result = "Summary: The Ten of Pentacles in a reversed position is said to give: Fatality, Destiny, Opportunity, Fate, Gratification, Dowry, Pension and also involves Decision.";
                }
            }


            // Page of Pentacles
            if (index == 33)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Page of Pentacles in an upright position is said to represent a dark, young man, a Disciple, a student, a speculator, a commercial man. Also: application, scholarship, study, reflexion, meditation, occupation, rule, management, news, message, and the messenger himself.";
                }
                else
                {
                    result = "Summary: The Page of Pentacles in a reverse position: The reverse meanings are here for once even given as favourable, for the greater part: Profession, Luxury, Over-Sumptuousness, Breadth, too much reliance on Abundance, over influenced by Magnificence, Liberality, Generosity, well-doing. Also: the Crowd, the Multitude, and finally Degradation and Dissipation.";
                }
            }


            // Knight of Pentacles
            if (index == 34)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Knight of Pentacles in an upright position represents: utility, advantage, serviceableness, profit, interest, gain, importance and necessity.";
                }
                else
                {
                    result = "Summary: The Knight of Pentacles in a reversed position is said to give: Repose, Tranquility, APATHY, Inertia, Idleness, Laziness, Discouragement, and also over-focus on Recreation.";
                }
            }


            // Queen of Pentacles
            if (index == 35)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Queen of Pentacles represents a dark worman who suggests 'the idea of a greatness of soul; she also has the serious cast of intelligence.' ConsiderL: Opulence, riches, luxury, assurance, security, liberty, and frankness.";
                }
                else
                {
                    result = "Summary: The Queen of Pentacles in a reversed position represents Doubt, Indecision, Uncertainty, Timidity, Apprehension, Vacillation.";
                }
            }


            // King of Pentacles
            if (index == 36)
            {
                if (isReversed == false)
                {
                    result = "Summary: The King of Pentacles in an upright position is said to indicate a dark man, banker, trader, speculator, mathematician, master, or professor. It points to success in mathematics and science in general.";
                }
                else
                {
                    result = "Summary: The King of Pentacles in a REVERSED position is given as Vice, Weakness, Corruption, Deformity, an Unwillingness to Think Things Through";
                }
            }


            // Ace of Wands
            if (index == 37)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Ace of Wands in an upright position is said to represent Birth, Source";
                }
                else
                {
                    result = "Summary: The Ace of Wands reversed indicates:  Fall, Perdition, Decadence, Decline, and Ruin.";
                }
            }


            // Two of Wands
            if (index == 38)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Two of Wands in an upright position indicates: Melancholy, Sadness, Surprise, Astonishment, Consternation, Terror, Fear, Enchantment, Trouble, but also on the other hand riches, fortune, and magnificence.";
                }
                else
                {
                    result = "Summary: The Two of Wands in a reversed position indicates: Lesser of Melancholy, Sadness, Surprise Astonishment, Consternation, Terror, Fear, Enchantment (in a bad sense), Trouble, but also on the other hand the lesser of Riches, Fortune, Magnificence.";
                }
            }


            // Three of Wands
            if (index == 39)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Three of Wands in an upright position usually indicates Enterprise, Effort, Essay, Trade, Commerce, Discovery, Usurpation, Daring, Temerity, and also Imprudence, Interruption, Cessation and  'The End of Troubles,' also Discontinuative.";
                }
                else
                {
                    result = "Summary: The Three of Wands in a reversed position is the Lesser of Enterprise, Effort, Essay, Trade, Commerce, Discovery, Usurpation, Daring, Temerity and also Imprudence, Interruption, Cessation";
                }
            }

            // Four of Wands
            if (index == 40)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Four of Wands in upright position indicates Society, Association, Alliance, Multitude, and all that implies a gathering of men, even armies, mixture; country life, felicity, augmentation, prosperity happiness, peace and concord, etc., convocation; advance.";
                }
                else
                {
                    result = "Summary: The Four of Wands in a reversed position represents the LESSER of Society, Association, Alliance, Multitude, and all that implies a gathering of people, even armies; mixture; country life, felicity, augmentation, prosperity, happiness, peace and concord, etc., convocation; advance.";
                }
            }

            // Five of Wands
            if (index == 41)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Five of Wands in an upright position represents Gold, Riches, Opulence, Nagnificence, Brilliancy, Luxury, The struggle for riches, 'physical, philosophical, and moral sun.' But also includes Process, Trickery, Contradiction, Discussion, Chicanery, etc.";
                }
                else
                {
                    result = "Summary: The Five of Wands in a REVERSED position represents the Lesser of Gold, Riches, Opulence, mangnificence, brilliancy, luxury and the magnification of the struggle for riches. It is also a magnification of Trickery, Contradiction, Discussion, and Chicanery.";
                }
            }


            // Six of Wands
            if (index == 42)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Six of Wands in an upright position represents Servant, Inferior, Mercenary man, Commissioner, the interior of a dwelling, a household. It is also said to denote Great News and Expectation, Hope and Trust, but not without some MISGIVINGS and a slight apprehension of TREACHERY.";
                }
                else
                {
                    result = "Summary: The Six of Wands in a REVERSED position represents the Lesser of the inferior, the servant, the mercenary, the commissioner, the interior of a dwelling, or the household. It is also said to denote Lesser news and expectation. Lesser hope and trust and an increase in misgivings and apprehension of TREACHERY.";
                }
            }


            // Seven of Wands
            if (index == 43)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Seven of Wands in an upright position represents Discussion, Negotiation, Conference, Conversation, Deliberation, Dissertation, Measure, Correspondence, Words and language, generally success, but there is also Hesitation, Uncertainty, Irresolution along with it.";
                }
                else
                {
                    result = "Summary: The Seven of Wands in the REVERSED position is the Lesser of Discussion, Negotiation, Conference, Conversation, Deliberation, etc, There is an increase in Hesitation, Uncertainty, and Irresolution.";
                }
            }

            // Eight of Wands
            if (index == 44)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Eight of Wands in an upright position represents Examination, interior disputes, misunderstanding, regrets, interior agitation, scruples, doubt, repentence, etc. But on the other hand it is brought into connection with everything that has to do with country life, the fields, gardens, woods, etc. Also: Pleasure, Amusement, Enjoyment, and Recreation. Quite apart from all this: an express messenger, the Arrows of Love or the Arrows of Jealousy. Great Haste, Great Hope, Speed towards an end, which promises assured felicity.";
                }
                else
                {
                    result = "Summary: The Eight of Wands in a REVERSED position represents the Lesser of Examination, interior disputes, misunderstanding, regrets, interior agitation, scruples, doubt, repentance, etc. But on the other hand it is brought into connection with everything that has to do with country life, the fields, gardens, woods, etc. Also: the lesser of pleasure, amusement, enjoyment, and recreation. Quite apart from all this -- an express messenger, the arrows of jealousy magnified. Great haste, lesser hope, great speed towards an end.";
                }
            }


            // Nine of Wands
            if (index == 45)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Nine of Wands in the upright position usually stands for Resilience, Courage, Persistence, test of faith, boundaries. ";
                }
                else
                {
                    result = "Summary: The Nine of Wands in the reversed position stands for inner resources, struggle, being overwhelmed, being defensive, and being paranoid.";
                }
            }

            // Ten of Wands
            if (index == 46)
            {
                if (isReversed == false)
                {
                    result = "Summary: The ten of wands in an upright position usually stands for Burden, Extra Responsibility, Hard work, and Completion.";
                }
                else
                {
                    result = "Summary: The ten of swords in a reversed position usually stands for Doint it All, Carrying the Burden, Delegation, and Release.";
                }
            }

            // Page of Wands
            if (index == 47)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Page of Wands in an upright position usually stands for Inspiration, Ideas, Discovery, limitless potential, and freedom of spirit.";
                }
                else
                {
                    result = "Summary: The Page of Wands in a reversed position usually means stands for newly-formed ideas, redirecting one's energy, self-limiting beliefs, and a spiritual path.";
                }
            }

            // Knight of Wands
            if (index == 48)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Knight of Wands in an upright position normally stands for Energy, Passion, Inspired Action, Adventure, and Impulsiveness.";
                }
                else
                {
                    result = "Summary: The Knight of wands in a reversed position normally stands for Passion Project, Haste, Scattered energy, Delays, and Frustration.";
                }
            }

            // Queen of Wands
            if (index == 49)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Queen of Wands in an Upright position stands for Courage, Confidence, Independence, Being a Social Butterfly, Being Determined.";
                }
                else
                {
                    result = "Summary: The Queen of Wands in a REVERSED position stands for Self-Respect, Self-Confidence, Introversion, re-establishment of the sense of Self.";
                }
            }

            // King of Wands
            if (index == 50)
            {
                if (isReversed == false)
                {
                    result = "Summary: The King of Wands in an upright position usually stands for Natural-born Leader, Grand Visions, and Long-term Success.";
                }
                else
                {
                    result = "Summary: The King of Wands in a REVERSED position usually stands for Poor Leadership, Aggressive Goals, High Expectations, personal direction.";
                }
            }

            // Ace of Cups
            if (index == 51)
            {
                if (isReversed == true)
                {
                    result = "Summary: The Ace of Wands in an upright position involved Love, New Relationships, Compassion, and Creativity.";
                }
                else
                {
                    result = "Summary: The Ace of Wands in a REVERSED position entails Self-Love, Intuition, Repressed emotions.";
                }
            }

            // Two of Cups
            if (index == 52)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Two of Cups in an upgright position usually has to do with Unified Love, Partnership, and Mutual Attraction.";
                }
                else
                {
                    result = "Summary: The Two of Cups in a REVERSED position usually means Self-Love, Break-Ups, Disharmony, and Distrust.";

                }
            }

            // Three of Cups
            if (index == 53)
            {
                if (isReversed == false)
                {
                    result = "Summary: The three of cups in an upright position stands for Celebration, Friendship, Creativity, and Collaboration.";
                }
                else
                {
                    result = "Summary: The three of cups in the reversed position stands for Independence, Alone-Time, Harcore Partying, and a Threes-a-Crowd mentality.";
                }
            }

            // Four of Cups
            if (index == 54)
            {
                if (isReversed == false)
                {
                    result = "Summary: The four of cups in the Upright position stands for Meditation, Contemplation, Apathy, and Re-Evaluation.";
                }
                else
                {
                    result = "Summary: The four of cups in the Reversed position stands for Retreat, Withdrawal, Checking in for alignment.";
                }
            }

            // Five of Cups
            if (index == 55)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Five of Cups in an upright position tends to stand for Revisiting the regret, failure, disappointment and pessimism.";
                }
                else
                {
                    result = "Summary: The Five of Cups in a reversed position tends to stand for Personal Setbacks, Self-Forgiveness, and moving on.";
                }
            }


            // Six of Cups
            if (index == 56)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Six of Cups in an upright position stands for Revisiting the Past, Childhood memories, Innocence, and Joy.";
                }
                else
                {
                    result = "Summary: The Six of cups in a reversed position stands for Living in the past, forgiveness, and having a lack of playfulness.";
                }
            }

            // Seven of Cups
            if (index == 57)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Seven of Cups in an upright position often stands for Opportunities, Choices, Wishful Thinking, and Illusion.";
                }
                else
                {
                    result = "Summary: The Seven of Cups in a reversed position often stands for Alignment, personal values, and being overwhelmed by choices.";
                }
            }

            // Eight of Cups
            if (index == 58)
            {
                if (isReversed == false)
                {
                    result = "Summary: The eight of cups in an upright position stands for Disappointment, Abandonment, Withdrawal, and Escapism.";
                }
                else
                {
                    result = "Summary: The eight of cups in a reversed position stands for Trying One More Time, Indecision, Aimless drifting, and walking away.";
                }
            }

            // Nine of Cups
            if (index == 59)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Nine of cups in an upright position tends to indicate Contentment, Satisfaction, Gratitude, and a Wish Come True.";
                }
                else
                {
                    result = "Summary: The Nine of cups in a reverse position tends to indicate Inner Happiness, Materialism, Dissatisfaction, and Indulgence.";
                }
            }

            // Ten of Cups
            if (index == 60)
            {
                if (isReversed == false)
                {
                    result = "Summary: The ten of cups in an upright position tends to stand for Divine Love, Blissful Relationships, Harmony, and Alignment.";
                }
                else
                {
                    result = "Summary: The ten of cups in a Reversed position tends to stand for Disconnection, Misaligned Values, Struggling Relationships, lack of a desire or ability to listen to higher wisdoms.";
                }
            }

            // Page of Cups
            if (index == 61)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Page of Cups in an upright position tends to stand for Creative Opportunities, Intuitive Messages, Curiosity, and Possibility.";
                }
                else
                {
                    result = "Summary: The Page of Cups in a reversed position tends to stand for New Ideas, Doubting Intuition, Creative Blocks, and Emotional Immaturity.";
                }
            }

            // Knight of Cups
            if (index == 62)
            {
                if (isReversed == false)
                {
                    result = "Summary: The knight of cups in an upright position tends to stand for Creativity, Romance, Charm, Imagination, and Beauty.";
                }
                else
                {
                    result = "Summary: The knight of cups in a reversed position tends to stand for Overactive Imagination, Unrealistic attitudes, jealousy, and moodiness.";
                }
            }

            // Queen of Cups
            if (index == 63)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Queen of Cups in an upright position stands for Being Compassionate, being caring, being emotionally stable, being intuitive, and being in the flow of things.";
                }
                else
                {
                    result = "Summary: The Queen of Cups in a reversed position stands for Inner Feelings, self-care, self-love, and co-dependency.";
                }
            }

            // King of Cups
            if (index == 64)
            {
                if (isReversed == false)
                {
                    result = "Summary: The King of Cups upright tends to stand for being emotionally balanced, while being compassionate and diplomatic.";
                }
                else
                {
                    result = "Summary: The King of Cups in a reversed position tends to stand for Self-Compassion while paying attention to inner feelings; being moody while also being emotionally manipulative.";
                }
            }

            // Ace of Swords
            if (index == 65)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Ace of Swords in an upright position tends to stand for breathroughs, new ideas, mental clarity, and success.";
                }
                else
                {
                    result = "Summary: The Ace of Swords in a reversed position tends to stand for Inner Clarity, re-thinking an idea, and having clouded judgment all at the same time.";
                }
            }

            // Two of Swords
            if (index == 66)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Two of Swords in an upright position tends to stand for Difficult Decisions, weighing your options, being at an impasse, and the problem of avoidance.";
                }
                else
                {
                    result = "Summary: The two of swords in a reversed position tends to stand for Indecision, Confusion, Information Overload, and being at a Stalemate all at the same time.";
                }
            }

            // Three of Swords
            if (index == 67)
            {
                if (isReversed == false)
                {
                    result = "Summary: The three of swords in an upright position stands for Heartbreak, Emotional Pain, Sorrow, Grief, and Hurt.";
                }
                else
                {
                    result = "Summary: The three of swords in a reversed position stands for negative self-talk, releasing pain, having some optimism, and having forgiveness (all at the same time).";
                }
            }

            // Four of Swords
            if (index == 68)
            {
                if (isReversed == false)
                {
                    result = "Summary: The four of swords in an upright position tends to stand for Rest, Relaxation, Meditation, Contemplation, and Recuperation.";
                }
                else
                {
                    result = "Summary: The four of swords in a reversed position tends to stand for Exhaustion, burn-out, deep contemplation, and stagnation";
                }
            }

            // Five of Swords
            if (index == 69)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Five of Swords in the upright position stands for Conflict, Disagreements, Competition, Defeat, and Winning at All Costs.";
                }
                else
                {
                    result = "Summary: The Five of Swords in a reversed position stands for Reconciliation, Making Amends, and Resentment over the Past.";
                }
            }

            // Six of Swords
            if (index == 70)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Six of Swords in an upright position stands for Transition, Change, Rite of Passage, or Releasing Baggage.";
                }
                else
                {
                    result = "Summary: The Six of Swords in a reversed position stands for Personal Transition, Resistance to Change, and Unfinished Business.";
                }
            }

            // Seven of Swords
            if (index == 71)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Seven of Swords in the upright position usually stands for Betrayal, Deception, Getting Away with Something, and Acting Strategically.";
                }
                else
                {
                    result = "Summary: The Seven of Swords in the Reversed position usually means Imposter Syndrome, Self-Deceit, and Keeping Secrets.";
                }
            }

            // Eight of Swords
            if (index == 72)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Eight of Swords usually indicates Negative Thoughts, Self-Imposed Restrictions, Imprisonment, and Victim Mentality";
                }
                else
                {
                    result = "Summary: The Eight of Swords in a reversed position usually means: Self-Limiting Beliefs, Inner Critic Strong, Releasing Negative Thoughts, and Open to New Perspectives.";
                }
            }

            // Nine of Swords
            if (index == 73)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Nine of Swords in an Upright position usually indicates Anxiety, Worry, Fear, Depression, along with Nightmares.";
                }
                else
                {
                    result = "Summary: The Nine of Swords in a Reversed position usually indicates Inner Turmoil, Deep-Seated Fears, Secrets, Releasing Worry";
                }
            }

            // Ten of Swords
            if (index == 74)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Ten of Swords in an upright position usually indicates Painful Endings, Deep Wounds, Betrayal, Loss, and Crisis.";
                }
                else
                {
                    result = "Summary: The Ten of Swords in a Reversed position usually indicates Reccovery, Regeneration, and Resisting an Inevitable End.";
                }
            }


            // Page of Swords
            if (index == 75)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Page of Swords in an Upright Position usually indicates New Ideas, Curiosity, Thirst for Knowledge, and New Ways of Communicating";
                }
                else
                {
                    result = "Summary: The Page of Swords in a Reversed Position usually indicates Self-Expression, All Talk and No Action, Haphazard Action, and Haste.";
                }
            }


            // Knight of Swords
            if (index == 76)
            {
                if (isReversed == false)
                {
                    result = "Summary: The Knight of Swords in an upright position usually indicates Ambitiousness, Being Action-Oriented, Being Driven to Succeed, and Fast-Thinking";
                }
                else
                {
                    result = "Summary: The Knight of Swords in a reversed position usually indicates Restlessness, Being Unfocused, Being Impulsive, and being Burned Out.";
                }
            }

            // Queen of Swords
            if (index == 77)
            {
                if (isReversed == false)
                {
                    result = "Summary: Summary: The Queen of Swords in an upright position usually indicates Being Indepent, Unbiased Judgment, Clear Boundaries, Direct Communication";
                }
                else
                {
                    result = "Summary: The Queen of Swords in a REVERSED position usually means being Overly Emotional, being Easily Influenced, being Bitchy, and being Cold-Hearted.";
                }
            }

            // King of Swords
            if (index == 78)
            {
                if (isReversed == false)
                {
                    result = "Summary: The King of Swords in an Upright position usually indicates Mental Clarity, Intellectual Power, Authority, and Truth";
                }
                else
                {
                    result = "Summary: The King of Swords in a Reversed position usually means Quiet Power, Inner Truth, Misuse or Abuse of Power, and Manipulation";
                }
            }




            return result;

        }

        private string GetQuotation(int index)
        {
            string result = string.Empty;
            if(index <= 1)
            {
                result = "There are two mistakes one can make along the road to truth... not going all the way, and not starting. -- Buddha";
            }
            else if(index == 2)
            {
                result = "Only one who devotes himself to a cause with his whole strength and soul can be a true master. For this reason master demands all of a person. -- Albert Einstein";
            }
            else if(index == 3)
            {
                result = "All perceiving is also thinking, all reasoning is also intuition, all observation is also invention. -- Rudolf Arnheim (psychologist)";
            }
            else if(index == 4)
            {
                result = "Spiritual and religious traditions, when shaped by the feminine principle, affirm the cyclical phases of our lives and the wisdom each phase brings, the sacredness of our bodies and the body of the Earth. --Patrick Wynne";
            }
            else if(index == 5)
            {
                result = "A leader is one who knows the way, goes the way, and shows the way. -- John C. Maxwell";
            }
            else if(index == 6)
            {
                result = "Teaching is more than imparting knowledge, it is inspiring change. Learning is more than absorbing facts, it is acquiring understanding. -- Wm. Arthur Ward (Author and Pastor)";
            }
            else if(index == 7)
            {
                result = "I love you not only for what you are but for what I am when I am with you. I love you not only for what you have made of yourself but for what you are making of me. I love you for the part of me that you bring out. --Roy Croft (poet)";
            }
            else if(index == 8)
            {
                result = "If you have willpower, then you can change anything. --The Dalai Lama";
            }
            else if(index == 9)
            {
                result = "Promise me you'll always remember: you are braver than you believe, and stronger than you seem, and smarter than you think. -- A. A. Milne";
            }
            else if(index == 10)
            {
                result = "There is a light within each of us than can never be diminished or extinguished. It can only be obscured by forgetting who we are. --Deepak Chopra.";
            }
            else if(index == 11)
            {
                result = "Tempt not the stars, young man, thou canst not play with the severity of fate. --John Ford (dramatist)";
            }
            else if(index == 12)
            {
                result = "The time is always right to do what is right. --Martin Luther King, Jr.";
            }
            else if(index == 13)
            {
                result = "If you change the way you look at things, the things you look at change. --Wayne Dyer";
            }
            else if(index == 14)
            {
                result = "A sun sets, a day is born. -- a Maori proverb";
            }
            else if(index == 15)
            {
                result = "Everything in moderation. --Aristotle";
            }
            else if(index == 16)
            {
                result = "Confront the dark parts of yourself, and work to banish them with illumination and forgiveness. Your willingness to wrestle with your demons will cause your angels to sing. Use the pain as fuel, as a reminder of your strength. --August Wilson (author)";
            }
            else if(index == 17)
            {
                result = "So go ahead. Fall down. The world looks different from the ground. --Oprah Winfrey";
            }
            else if(index == 18)
            {
                result = "If you follow your star, you cannot fail of glorious heaven. --Dante Alighieri (poet)";
            }
            else if (index == 19)
            {
                result = "Everyone is a moon and has a dark side which he never shows to anybody. --Mark Twain";
            }
            else if (index == 20)
            {
                result = "Once we recognize what is is we are feeling, once we recognise we can feel deeply, love deeply, can feel joy, then we will demand that all parts of our lives produce that kind of joy. --Audre Lorde (writer, poet, and activist)";
            }
            else if (index == 21)
            {
                result = "People move forward into the future out of the way they comprehend the past. When we do not understand something in our past, we are therefore crippled. --Norman Mailer (novelist, journalist, and poet)";
            }
            else if (index == 22)
            {
                result = "Success is peace of mind which is a direct result of self-satisfaction in knowing you did your best to become the best you are capable of becoming. -- John Wooden";
            }
            else if (index == 23) // Ace of Pentacles
            {
                result = "Prosperity in the form of wealth works exactly the same as everything else. You will see it coming into your life when you are unattached to needing it. -- Wayne Dyer";
            }
            else if (index == 24) // Two of Pentacles
            {
                result = "Set priorities for your goals. A major part of successful living lies in the ability to put first things first. Indeed, the reason most major goals are not achieved is that we spend our time doing second things first. --Robert J. Mckain";
            }
            else if (index == 25)  //Three of Pentacles
            {
                result = "Teamwork is so important that it is virtually impossible for you to reach the heights of your capabilities or make the money that you want without becoming very good at it. --Brian Tracy (author)";
            }
            else if (index == 26) // Four of Pentacles
            {
                result = "The art is not in making money, but in keeping it. --proverb";
            }
            else if (index == 27) // Five of Pentacles
            {
                result = "Being unwanted, unloved, uncared for, forgotten by everybody, I think that is a much greater hunger, a much greater poverty than the person who has nothing to eat. --Mother Teresa";
            }
            else if (index == 28) // Six of Pentacles
            {
                result = "If you have much, give of your wealth; if you have little, give of your heart. -- an Arabian proverb";
            }
            else if (index == 29) // Seven of Pentacles
            {
                result = "Live your life each day as you would climb a mountain. An occasional glace toward the summit keeps the goal in mind but many beautiful scenes are to be observed from each new vantage point. Climb slowly, steadily, enjoying each passing moment; and the view from the summit will serve as a fitting climax for the journey. --Harold B. Melchart";
            }
            else if (index == 30) // Eight of Pentacles
            {
                result = "Try to pick a profession in which you enjoy even the most mundane, tedious parts. Then you will always be happy. --Will Shortz (puzzle guy)";
            }
            else if (index == 31) // Nine of Pentacles
            {
                result = "Both abundance and lack exist simultaneously in our lives, as parallel realities. It is always our conscious choice which secret garden we will tend.... When we choose not to focus on what is missing from our lives but are grateful for the abundance that's present --love, health, family, friends, work, the joys of nature, and personal pursuits that bring us pleasure -- the wasteland of illusion falls away and we experience Heaven on Earth. -- Sarah Ban Breathnach (author)";
            }
            else if (index == 32) // Ten of Pentacles
            {
                result = "When a man has done his best, has given his all, and in the process supplied the needs of his family and his society, that man has made a habit of succeeding. --Mack R. Douglas (author and speaker)";
            }
            else if (index == 33) // Page of Pentacles
            {
                result = "Write it down. Written goals have a way of transforming wishes into wants; cant's into cans; dreams into plans; and plans into reality. Do not just think it -- ink it!  (--author unknown)";
            }
            else if (index == 34) // Knight of Pentacles
            {
                result = "Effort only fully releases its reward after a person refuses to quit. --Napoleon Hill";
            }
            else if (index == 35) // Queen of Pentacles
            {
                result = "Life-fulfilling work is never about the money -- when you feel true passion for something, you instinctively find ways to nurture it. --Eileen Fisher";
            }
            else if (index == 36) // King of Pentacles
            {
                result = "A wise man does not just wait for the right opportunity, he creates the right opportunity. (author unknown)";
            }
            else if (index == 37) // Ace of Wands
            {
                result = "Creativity can solve almost any problem. The creative act, the defeat of habit by originality, overcomes everything. --George Lois";
            }
            else if (index == 38) // Two of Wands
            {
                result = "To solve a problem or to reach a goal, you do not need to know all the answers in advance. But you must have a clear idea of the problem or the goal you want to reach. --W. Clement Stone";
            }
            else if (index == 39)  // Three of Wands
            {
                result = "Small opportunities are often the beginning of great enterprises. - Demosthenes";
            }
            else if (index == 40) // Four of Wands
            {
                result = "Happiness lies in the joy of achievement and the thrill of creative effort. -- Franklin D. Roosevelt";
            }
            else if (index == 41) // Five of Wands
            {
                result = "Until you have learned to be tolerant with those who do not always agree with you; until you have cultivated the habit of saying some kind word of those whom you do not admire; until you have formed the habit of looking for the good instead of the bad there is in others, you will be neither successful nor happy.  - Napoleon Hill (author)";
            }
            else if (index == 42) // Six of Wands
            {
                result = "It is important that you recognise your progress and take pride in your accomplishments. Share your achievements with others. Brag a little. The recognition and support of those around you is nurturing.  - Rosemarie Rossetti ";
            }
            else if (index == 43) // Seven of Wands
            {
                result = "It is fatal to enter any war without the will to win it.  - Douglas MacArthur";
            }
            else if (index == 44) // Eight of Wands
            {
                result = "Inaction breeds doubt and fear. Action breeds confidence and courage. If you want to conquer fear, do not sit home and think about it. Go out and get busy.  - Dale Carnegie (writer)";
            }
            else if (index == 45) // Nine of Wands
            {
                result = "Only a man who knows what it is like to be defeated can reach down to the bottom of his soul and come up with the extra ounce of power it takes to win when the match is even.  - Muhammad Ali (boxer)";
            }
            else if (index == 46) // Ten of Wands
            {
                result = "Determination gives you the resolve to keep going in spite of the roadblocks that lay before you.  - Denis Waitley (author and speaker)";
            }
            else if (index == 47) // Page of Wands
            {
                result = "Right now you are one choice away from a new beginning- one that leads you toward becoming the fullest human being you can be.  - Oprah Winfrey";
            }
            else if (index == 48) // Knight of Wands
            {
                result = "Risk is essential. There is not growth of inspiration in staying within what is safe and comfortable. Once you find out what you do best, why not try something else?  - Alex Noble (artist)";
            }
            else if (index == 49) // Queen of Wands
            {
                result = "Character contributes to beauty. It fortifies a woman as her youth fades. A mode of conduct, a standard of courage, discipline, fortitude and integrity can do a great deal to make a woman beautiful.  - Jacqueline Bisset (actress)";
            }
            else if (index == 50) // King of Wands
            {
                result = "Self-determination has to mean that the leader is your individual gut, and heart, and mind or we're talking about power, again, and its rather well-known impurities. Who is really going to care whether you live or die and who is going to know the most intimate motivation for your laughter and your tears is the only person to be trusted to speak for you and to decide what you will or will not do.  - June Jordan (poet and novelist)";
            }
            else if (index == 51)  // Ace of Cups
            {
                result = "Let your love be like the misty rains, coming softly but flooding the river.  - Malagasy proverb";
            }
            else if (index == 52)  // Two of Cups
            {
                result = "Love one another but make not a bond of love: Let it rather be a moving sea between the shores of your souls.  - Kahlil Gibran (philosophical novelist and poet)";
            }
            else if (index == 53) // Three of Cups
            {
                result = "Maybe our girlfriends are our soul mates and guys are just people to have fun with.  - Candace Bushnell (author of Sex and the City)";
            }
            else if (index == 54)  // Four of Cups
            {
                result = "A man, who realises the potential of his mind by means of introspection and contemplation, he does not lack self- confidence. He has control over his mind and he is able to realise its full potential. - Sama Veda (ancient Hindu scripture)";
            }
            else if (index == 55) // Five of Cups
            {
                result = "The secret of health for both mind and body is not to mourn for the past, worry about the future, or anticipate troubles but to live in the present moment wisely and earnestly. - Buddha";
            }
            else if (index == 56)  // Six of Cups
            {
                result = "Keeping in touch with childhood memories keeps us believing in life's simplest pleasures like a rainy afternoon, a swing set, and a giant puddle to play in. - Chrissy Ogden (photographer)";
            }
            else if (index == 57)  // Seven of Cups
            {
                result = "If you have built castles in the air, your work need not be lost; that is where they should be. Now put the foundations under them. - Henry David Thoreau (author of Walden)";
            }
            else if (index == 58) // Eight of Cups
            {
                result = "This is not a problem that we can turn away from. We must be prepared to face it. We must not let the sensible reluctance to fight drive us into wishful thinking. - Richard Armitage (actor)";
            }
            else if (index == 59) // Nine of Cups
            {
                result = "Be thankful for what you have; you'll end up having more. If you concentrate on what you don't have, you will never, ever have enough. Oprah Winfrey";
            }
            else if (index == 60) // Ten of Cups
            {
                result = "Our family is a circle of love and strength. With every birth and every union, the circle grows. Every joy shared adds more love. Every obstacle faced together makes the circle stronger. - Anonymous";
            }
            else if (index == 61) // Page of Cups
            {
                result = "If one advances confidently in the directions of his dreams, and endeavours to live the life which he has imagined, he will meet with a success unexpected in common hours. - Henry David Thoreau (author)";
            }
            else if (index == 62) // Knight of Cups
            {
                result = "It will be found, in fact, that the ingenious are always fanciful, and the truly imaginative never otherwise than analytic. - Edgar Allan Poe (author and poet)";
            }
            else if (index == 63) // Queen of Cups
            {
                result = "Make decisions from the heart and use your head to make it work out. - Sir Girad";
            }
            else if (index == 64) // King of Cups
            {
                result = "Compassion is more important than intellect in calling forth the love that the work of peace needs, and intuition can often be a far more powerful searchlight than cold reason. - Betty Williams (author)";
            }
            else if (index == 65)  // Ace of Swords
            {
                result = "Whatever the mind of man can conceive and believe, it can achieve. Thoughts are things! And powerful things at that, when mixed with definiteness of purpose, and burning desire, can be translated into riches. - Napolean Hill (motivational author)";
            }
            else if (index == 66) // Two of Swords
            {
                result = "Each indecision brings its own delays and days are lost lamenting over lost days.. What you can do or think you can do, begin it. Por boldness has magic, power, and genius in it. - Johann Wolfgang von Goethe (writer)";
            }
            else if (index == 67) // Three of Swords
            {
                result = "But how will I know who my soul mate is? By taking risks. By risking failure, disappointment, disillusion but never ceasing in your search for love. As long as you keep looking, you will triumph in the end. - Paulo Coelho (author)";
            }
            else if (index == 68) // Four of Swords
            {
                result = "Peace comes from within. Do not seek it without. --The Buddha";
            }
            else if (index == 69)  // Five of Swords
            {
                result = "You may have to fight a battle more than once to win it.- Margaret Thatcher (British Prime Minister)";
            }
            else if (index == 70) // Six of Swords
            {
                result = "Travelling is not just seeing the new; it is also leaving behind. Not just opening doors; also closing them behind you, never to return. But the place you have left forever is always there for you to see whenever you shut your eyes. -Jan Myrdal (author)";
            }
            else if (index == 71) // Seven of Swords
            {
                result = "A lie told often enough becomes the truth. --Lenin";
            }
            else if (index == 72)  // Eight of Swords
            {
                result = "Don't limit yourself. Many people limit themselves to what they think they can do. You can go as far as your mind lets you. What you believe, remember, you can achieve. - Mary Kay Ash (Founder, Mary Kay Cosmetics)";
            }
            else if (index == 73)  // Nine of Swords
            {
                result = "The task of worrying is to come up with positive solutions for life's perils by anticipating dangers before they arise. If we are preoccupied by worries, we have much less attention to expend on figuring out the answers. Our worries become self- fulfilling prophecies, propelling us toward the very disaster they predict. - Daniel Goleman (author and psychologist)";
            }
            else if (index == 74) // Ten of Swords
            {
                result = "The traveller has reached the end of the journey! In the freedom of the infinite he is free from all sorrows, the fetters that bound him are thrown away, and the burning fever of life is no more. - Dhammapada (Buddhist collection of moral aphorism)";
            }
            else if (index == 75) // Page of Swords
            {
                result = "I could not, at any age, be content to take my place by the fireside and simply look on. Life was meant to be lived. Curiosity must be kept alive. One must never, for whatever reason, turn his back on life. -- Eleanor Roosevelt (United Nations diplomat)";
            }
            else if (index == 76) // Knight of Swords
            {
                result = "I could not, at any age, be content to take my place by the fireside and simply look on. Life was meant to be lived. Curiosity must be kept alive. One must never, for whatever reason, turn his back on life. -- Eleanor Roosevelt (United Nations diplomat)";
            } 
            else if (index == 77) // Queen of Swords
            {
                result = "I'm tough, I'm ambitious, and I know exactly what I want. If that makes me a bitch, okay. - Madonna";
            }
            else if (index == 78) // King of Swords
            {
                result = "A wise man makes his own decisions, an ignorant man follows the public opinion. - Grantland Rice (American journalist)";
            }
            

            return result;
        }

        private string GetDisplayName(int index)
        {
            if (index == 0)
            {
                return "The Fool";
            }
            else if (index == 1)
            {
                return "The Fool";
            }
            else if (index == 2)
            {
                return "The Magician";
            }
            else if (index == 3)
            {
                return "The High Priestess";
            }
            else if (index == 4)
            {
                return "The Empress";
            }
            else if (index == 5)
            {
                return "The Emperor";
            }
            else if (index == 6)
            {
                return "The Hierophant";
            }
            else if (index == 7)
            {
                return "The  Lovers";
            }
            else if (index == 8)
            {
                return "The Chariot";
            }
            else if (index == 9)
            {
                return "Strength";
            }
            else if (index == 10)
            {
                return "The Hermit";
            }
            else if (index == 11)
            {
                return "Wheel of Fortune";
            }
            else if (index == 12)
            {
                return "Justice";
            }
            else if (index == 13)
            {
                return "The Hanged Man";
            }
            else if (index == 14)
            {
                return "Death";
            }
            else if (index == 15)
            {
                return "Temperance";
            }
            else if (index == 16)
            {
                return "The Devil";
            }
            else if (index == 17)
            {
                return "The Tower";
            }
            else if (index == 18)
            {
                return "The Star";
            }
            else if (index == 19)
            {
                return "The Moon";
            }
            else if (index == 20)
            {
                return "The Sun";
            }
            else if (index == 21)
            {
                return "Judgment";
            }
            else if (index == 22)
            {
                return "The World";
            }
            else if (index == 23)
            {
                return "Ace of Pentacles";
            }
            else if (index == 24)
            {
                return "Two of Pentacles";
            }
            else if (index == 25)
            {
                return "Three of Pentacles";
            }
            else if (index == 26)
            {
                return "Four of Pentacles";
            }
            else if (index == 27)
            {
                return "Five of Pentacles";
            }
            else if (index == 28)
            {
                return "Six of Pentacles";
            }
            else if (index == 29)
            {
                return "Seven of Pentacles";
            }
            else if (index == 30)
            {
                return "Eight of Pentacles";
            }
            else if (index == 31)
            {
                return "Nine of Pentacles";
            }
            else if (index == 32)
            {
                return "Ten of Pentacles";
            }
            else if (index == 33)
            {
                return "Page of Pentacles";
            }
            else if (index == 34)
            {
                return "Knight of Pentacles";
            }
            else if (index == 35)
            {
                return "Queen of Pentacles";
            }
            else if (index == 36)
            {
                return "King of Pentacles";
            }
            else if (index == 37)
            {
                return "Ace of Wands";
            }
            else if (index == 38)
            {
                return "Two of Wands";
            }
            else if (index == 39)
            {
                return "Three of Wands";
            }
            else if (index == 40)
            {
                return "Four of Wands";
            }
            else if (index == 41)
            {
                return "Five of Wands";
            }
            else if (index == 42)
            {
                return "Six of Wands";
            }
            else if (index == 43)
            {
                return "Seven of Wands";
            }
            else if (index == 44)
            {
                return "Eight of Wands";
            }
            else if (index == 45)
            {
                return "Nine of Wands";
            }
            else if (index == 46)
            {
                return "Ten of Wands";
            }
            else if (index == 47)
            {
                return "Page of Wands";
            }
            else if (index == 48)
            {
                return "Knight of Wands";
            }
            else if (index == 49)
            {
                return "Queen of Wands";
            }
            else if (index == 50)
            {
                return "King of Wands";
            }
            else if (index == 51)
            {
                return "Ace of Cups";
            }
            else if (index == 52)
            {
                return "Two of Cups";
            }
            else if (index == 53)
            {
                return "Three of Cups";
            }
            else if (index == 54)
            {
                return "Four of Cups";
            }
            else if (index == 55)
            {
                return "Five of Cups";
            }
            else if (index == 56)
            {
                return "Six of Cups";
            }
            else if (index == 57)
            {
                return "Seven of Cups";
            }
            else if (index == 58)
            {
                return "Eight of Cups";
            }
            else if (index == 59)
            {
                return "Nine of Cups";
            }
            else if (index == 60)
            {
                return "Ten of Cups";
            }
            else if (index == 61)
            {
                return "Page of Cups";
            }
            else if (index == 62)
            {
                return "Knight of Cups";
            }
            else if (index == 63)
            {
                return "Queen of Cups";
            }
            else if (index == 64)
            {
                return "King of Cups";
            }
            else if (index == 65)
            {
                return "Ace of Swords";
            }
            else if (index == 66)
            {
                return "Two of Swords";
            }
            else if (index == 67)
            {
                return "Three of Swords";
            }
            else if (index == 68)
            {
                return "Four of Swords";
            }
            else if (index == 69)
            {
                return "Five of Swords";
            }
            else if (index == 70)
            {
                return "Six of Swords";
            }
            else if (index == 71)
            {
                return "Seven of Swords";
            }
            else if (index == 72)
            {
                return "Eight of Swords";
            }
            else if (index == 73)
            {
                return "Nine of Swords";
            }
            else if (index == 74)
            {
                return "Ten of Swords";
            }
            else if (index == 75)
            {
                return "Page of Swords";
            }
            else if (index == 76)
            {
                return "Knight of Swords";
            }
            else if (index == 77)
            {
                return "Queen of Swords";
            }
            else if (index == 78)
            {
                return "King of Swords";
            }
            else
            {
                return "Unk";
            }
        }

        // Return a random integer between a min and max value.
        int RandomIntFromRNG(int min, int max)
        {
            // Generate four random bytes
            byte[] four_bytes = new byte[4];
            CryptoRNG.GetBytes(four_bytes);

            // Convert the bytes to a UInt32
            UInt32 scale = BitConverter.ToUInt32(four_bytes, 0);

            // And use that to pick a random number >= min and < max
            return (int)(min + (max - min) * (scale / (uint.MaxValue + 1.0)));
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int min = 1;
            int max = 78;
            int index = RandomIntFromRNG(min, max);
            lblQuote.Text = "";
            lblQuote.Text += "Capture" + index.ToString("D2");
            string suffix = index.ToString("D2");
            string cardImageName = "Capture" + suffix;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImage = (System.Drawing.Image)Resources.ResourceManager.GetObject(cardImageName);
            pictureBox1.Refresh();
            lblName.Text = GetDisplayName(index);
            bool isReversed = DetermineReversal();
            lblSummary.Text = GetSummary(index, isReversed);
            lblQuote.Text = GetQuotation(index);
        }

        /// <summary>
        /// Creates the basic Tarot Journal data for pasting into Notepad, so the user can make their own tarot journal entries every time they draw a card.
        /// </summary>
        /// <param name="sender">menu item</param>
        /// <param name="e">menu item</param>
        private void createTarotJournalDataAndCopyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. The info to copy will be:
            // 2. The Intent of the Card Drawn
            // 3. The Card Drawn - it's name.
            // 4. The Card Summary - do I include the quotation? not right now.
            // 5. My Interpretation on what card I drew.

            // 1. create a variable to hold the final string.
            string src = string.Empty;

            // 2. get the Intent first.
            src = "Reason for Drawing a Card (Intention)" + txtIntent.Text + "\n";

            // 3. get which card was drawn
            src += "Card Drawn Was:  " + lblName.Text + "\n";

            // 4. get what the Card Means:
            src += "Card Meaning or Summary: " + lblSummary.Text + "\n";

            // 5. get what my interpretation
            src += "Author's Interpretation is: " + txtInterpretation.Text + "\n";
            
            // 6. Get whay my decision is:
            src += "My Decision is:  " + txtDecision.Text + "\n\n";

            // 7. Copy to the ClipBoard
            Clipboard.SetText(src); 

        }

        private void ShrinkForm()
        {
            this.Width = 562;
            this.Height = 832;
        }

        /// <summary>
        /// When the user clicks on the Reveal button, a hidden part of the form
        /// is revealed - with a panel and new controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReveal_Click(object sender, EventArgs e)
        {
            if(CurrentFormState == 0)
            {
                ShrinkForm();
                btnReveal.Text = "Expand";
                CurrentFormState = 1;
                lblFormSize.Text = "Height = 832, Width = 565";
  
                return;
            }
            this.Width = 1045;
            this.Height = 832;
            CurrentFormState = 0;
            btnReveal.Text = "Shrink";
            lblFormSize.Text = "Height = 832, Width=1045";
 

        }
    }
}
