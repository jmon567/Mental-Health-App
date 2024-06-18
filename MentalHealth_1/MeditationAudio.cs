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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
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
            panel_174.BackColor = Color.Green;
            panel_285.BackColor = Color.White;

            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;

            try
            {
                SoundPlayer Audio174 = new SoundPlayer();
                //Audio174.SoundLocation = @"C:iClould Drive\Desktop\**MS539Code_VS\MentalHealthApp\MentalHealth_1\MentalHealth_1\bin\Debug\net8.0-windows\174Hz.m4a";
                Audio174.SoundLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"/AudioWAV/174Hz.wav");
                //Audio174.SoundLocation =  @"/AudioWAV/174Hz.wav";

                Audio174.Load();
                Audio174.PlayLooping();

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_174, "Audio Not Found");
                throw ex;
                //Console.WriteLine("Audio Not Found");
            }





        }

        private void pictureBox_285_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.Green;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;
        }

        private void pictureBox_396_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.Green;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;
        }

        private void pictureBox_417_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.Green;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;
        }

        private void pictureBox_528_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.Green;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;
        }

        private void pictureBox_639_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.Green;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;
        }

        private void pictureBox_741_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.Green;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;
        }

        private void pictureBox_852_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.Green;
            panel_963.BackColor = Color.White;
        }

        private void pictureBox_963_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.Green;
        }
    }
}



        
    
