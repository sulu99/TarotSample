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
using RndSample.Properties;

namespace RndSample
{
    public partial class Form1 : Form
    {
        RandomNumberGenerator CryptoRNG;

        public Form1()
        {
            InitializeComponent();
            CryptoRNG = RandomNumberGenerator.Create();
        }


        private void drawOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int min = 0;
            int max = 77;
            int index = RandomIntFromRNG(min, max);

            string suffix = index.ToString("D2");
            string cardImageName = Capture + suffix + ".PNG";
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImage = (System.Drawing.Image)Resources.ResourceManager.GetObject(cardImageName);

        }

        private static byte[] GenerateSaltNewInstance(int size)
        {
            using (var generator = RandomNumberGenerator.Create())
            {
                var salt = new byte[size];
                generator.GetBytes(salt);
                return salt;
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
    }
}
