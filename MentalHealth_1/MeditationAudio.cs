using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MentalHealth_1
{
    public partial class MeditationAudio : Form
    {
        public MeditationAudio()
        {
            InitializeComponent();
            bool Hz174 = false;
            bool Hz285 = false;
            bool Hz396 = false;
            bool Hz417 = false;
            bool Hz528 = false;
            bool Hz639 = false;
            bool Hz741 = false;
            bool Hz852 = false;
            bool Hz963 = false;

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Meditation meditation = new Meditation();
            meditation.ShowDialog();
        }

        private void button_stopaudio_Click(object sender, EventArgs e)
        {
            bool Hz174 = false;
            bool Hz285 = false;
            bool Hz396 = false;
            bool Hz417 = false;
            bool Hz528 = false;
            bool Hz639 = false;
            bool Hz741 = false;
            bool Hz852 = false;
            bool Hz963 = false;
        }
    }
}
