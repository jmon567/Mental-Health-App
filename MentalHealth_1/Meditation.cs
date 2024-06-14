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
    public partial class Meditation : Form
    {
        public Meditation()
        {
            InitializeComponent();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard form3 = new Dashboard();
            form3.ShowDialog();

        }

        private void button_audio_Click(object sender, EventArgs e)
        {
            this.Close();
            MeditationAudio meditationAudio = new MeditationAudio();
            meditationAudio.ShowDialog();
        }

        private void button_poses_Click(object sender, EventArgs e)
        {
            pictureBox_Poses.Visible = true;
            richTextBox_Facts.Visible = false;
            pictureBox_Front.Visible = false ;
        }

        private void button_facts_Click(object sender, EventArgs e)
        {
            richTextBox_Facts.Visible = true;
            pictureBox_Poses.Visible = false ;
            pictureBox_Front.Visible = false;
        }
    }
}
