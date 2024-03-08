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
    public partial class BuildMRU : Form
    {
        string sMotivatingStimulus = string.Empty;
        string sFeeling = string.Empty;
        string sAction = string.Empty;
        string sSpeech = string.Empty;
        string sResult = string.Empty;

        public BuildMRU()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStimulus.Text = string.Empty;
            txtFeeling.Text = string.Empty;
            txtAction.Text = string.Empty;
            txtResult.Text = string.Empty;
            txtSpeech.Text = string.Empty;
            sMotivatingStimulus = string.Empty;
            sFeeling = string.Empty;
            sAction = string.Empty;
            sSpeech = string.Empty;
            sResult = string.Empty;

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sResult);
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            string sl = "\r\n";
            sMotivatingStimulus = txtStimulus.Text;
            sFeeling = txtFeeling.Text;
            sAction = txtAction.Text;
            sSpeech = txtSpeech.Text;
            sResult = "Motivating Stimulus: " + sMotivatingStimulus + sl;
            sResult += "Feeling: " + sFeeling + sl;
            sResult += "Action: " + sAction + sl;
            sResult += "Speech: " + sSpeech + sl;
            txtResult.Text = sResult;
        }

        private void btnShowExample_Click(object sender, EventArgs e)
        {
            txtStimulus.Text = "You ever see such a place for rain?, said Toadvine.";
            txtFeeling.Text = "[UNSPECIFIED]";
            txtAction.Text = "He turned to the man who spoke. He wore long moustaches after the fashion of teamsters and he wore a widebrim hat with a low round crown.";
            txtSpeech.Text = "I just got here, said the kid.";
        }
    }
}
