using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Security.Cryptography;

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

        private void pictureBox_174_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer Audio174 = new SoundPlayer();
                // Audio174.SoundLocation = @"C:\\Mac\Home\Desktop\MS539Code_VS\MentalHealthApp\MentalHealth_1\MentalHealth_1\AudioWAV\174Hz.wav";
                Audio174.SoundLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AudioWAV\\174Hz.wav");
                if (File.Exists(Audio174.SoundLocation))
                {
                  
                    MessageBox.Show("Test");
                }
                Audio174.Load();
                Audio174.Play();

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_174, "Audio Not Found");
            }
        }

       
    }



        
    
}
